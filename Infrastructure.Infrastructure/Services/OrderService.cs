using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Shipping;
using ReelsCommerceSystem.Application.Exceptions;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Domain.Services;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OrderSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICartCacheService _cartCache;
    private readonly INotificationService _notificationService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<User> _userManager;
    private readonly IFinanceService _financeService;

    private decimal CalculateShipping(DeliveryMethod method)
    {
        return method switch
        {
            DeliveryMethod.Standard => 60,
            DeliveryMethod.Express => 120,
            DeliveryMethod.HomeDelivery => 80,
            _ => 60
        };
    }

    public OrderService(IUnitOfWork unitOfWork, ICartCacheService cartCache, INotificationService notificationService, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IFinanceService financeService)
    {
        _unitOfWork = unitOfWork;
        _cartCache = cartCache;
        _notificationService = notificationService;
        _httpContextAccessor = httpContextAccessor;
        _userManager = userManager;
        _financeService = financeService;
    }

    private string? ResolveImageUrl(string? url)
    {
        if (string.IsNullOrEmpty(url)) return url;
        if (url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
            url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            return url;

        var request = _httpContextAccessor.HttpContext?.Request;
        if (request == null) return url;

        var baseUrl = $"{request.Scheme}://{request.Host}";
        return $"{baseUrl}/{url.TrimStart('/')}";
    }

    public async Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus, string userRole, string userId)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null) return false;

        if (!OrderStateMachine.IsVisibleToRole(order.PaymentStatus, userRole))
            throw new OrderNotVisibleException("Order is not available for this role.");

        if (order.OrderStatus == newStatus) return true;

        bool allowed = userRole switch
        {
            string r when r == SystemRoles.BrandOwner || r == SystemRoles.BrandEmployee => OrderStateMachine.IsBrandTransitionAllowed(order.OrderStatus, newStatus),
            _ => false
        };

        if (!allowed)
            throw new InvalidOrderTransitionException(
                $"Transition from {order.OrderStatus} to {newStatus} is not allowed for role {userRole}.");

        order.OrderStatus = newStatus;
        _unitOfWork.Repository<Order>().Update(order);
        var result = await _unitOfWork.SaveChangesAsync();

        if (result > 0)
        {
            await _notificationService.SendOrderStatusNotificationAsync(order, newStatus);
            return true;
        }

        return false;
    }

    public async Task CancelOrderAsync(int orderId, string userId, string userRole)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null)
            throw new NotFoundException("Order not found");

        if (order.OrderStatus == OrderStatus.Cancelled)
            throw new InvalidOrderTransitionException("Order is already cancelled.");

        if (order.CancellationRequested)
            throw new InvalidOrderTransitionException("Cancellation has already been requested for this order.");

        bool canCancel = userRole switch
        {
            SystemRoles.User => OrderStateMachine.CanUserCancel(order.OrderStatus),
            string r when r == SystemRoles.BrandOwner || r == SystemRoles.BrandEmployee => OrderStateMachine.CanBrandCancel(order.OrderStatus),
            _ => false
        };

        if (!canCancel)
            throw new InvalidOrderTransitionException(
                $"Cancellation is not allowed for role {userRole} when order status is {order.OrderStatus}.");

        bool requiresRefund = OrderStateMachine.RequiresAdminRefund(order.PaymentStatus, order.PaymentMethod);

        if (requiresRefund)
        {
            order.CancellationRequested = true;
            _unitOfWork.Repository<Order>().Update(order);
            await _unitOfWork.SaveChangesAsync();
            await _notificationService.SendAdminRefundRequestNotificationAsync(order);
            return;
        }

        order.OrderStatus = OrderStatus.Cancelled;
        order.CancellationRequested = true;
        if (order.PaymentStatus == PaymentStatus.Pending && order.PaymentMethod == PaymentMethod.CashOnDelivery)
        {
            order.PaymentStatus = PaymentStatus.Pending;
        }

        _unitOfWork.Repository<Order>().Update(order);
        await _unitOfWork.SaveChangesAsync();

        await _notificationService.SendCancellationNotificationAsync(order, userId, userRole);
    }

    public async Task ProcessRefundAsync(int orderId, string adminId)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null)
            throw new NotFoundException("Order not found");

        if (order.OrderStatus == OrderStatus.Cancelled && order.PaymentStatus == PaymentStatus.Refunded)
            throw new InvalidOrderTransitionException("Order is already cancelled and refunded.");

        order.PaymentStatus = PaymentStatus.Refunded;
        order.OrderStatus = OrderStatus.Cancelled;

        _unitOfWork.Repository<Order>().Update(order);
        await _unitOfWork.SaveChangesAsync();

        await _notificationService.SendRefundNotificationAsync(order);
        await _notificationService.SendCancellationNotificationAsync(order, adminId, SystemRoles.Admin);
    }

    public async Task<List<RefundRequestDto>> GetRefundRequestsAsync()
    {
        var orders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.CancellationRequested && o.OrderStatus != OrderStatus.Cancelled)
            .Include(o => o.User)
            .Include(o => o.OrderProducts)
            .OrderByDescending(o => o.UpdatedAt)
            .ToListAsync();

        return orders.Select(o => new RefundRequestDto
        {
            OrderId = o.Id,
            CustomerName = o.User?.DisplayName ?? "Unknown",
            CustomerEmail = o.User?.Email ?? "",
            TotalAmount = o.TotalAmount,
            PaymentMethod = o.PaymentMethod,
            PaymentStatus = o.PaymentStatus,
            CreatedAt = o.CreatedAt,
            CancellationRequestedAt = o.UpdatedAt,
            ItemCount = o.OrderProducts.Sum(op => op.Quantity),
            ProductNames = o.OrderProducts.Select(op => op.ProductName).ToList()
        }).ToList();
    }

    public async Task<List<ReadyToShipOrderDto>> GetReadyToShipOrdersAsync()
    {
        var orders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.OrderStatus == OrderStatus.Packed || o.OrderStatus == OrderStatus.Shipped)
            .Include(o => o.OrderProducts)
            .ToListAsync();

        return orders.Select(o => new ReadyToShipOrderDto
        {
            OrderId = o.Id,
            CreatedAt = o.CreatedAt,
            TotalAmount = o.TotalAmount,
            ShippingName = o.ShippingName,
            ShippingStreet = o.ShippingStreet,
            ShippingCity = o.ShippingCity,
            ShippingCountry = o.ShippingCountry,
            ShippingPostalCode = o.ShippingPostalCode,
            ShippingPhoneNumber = o.ShippingPhoneNumber,
            OrderStatus = o.OrderStatus,
            PaymentMethod = o.PaymentMethod,
            PaymentStatus = o.PaymentStatus,
            Items = o.OrderProducts.Select(op => new ReadyToShipOrderItemDto
            {
                ProductName = op.ProductName,
                Quantity = op.Quantity
            }).ToList()
        }).ToList();
    }

    public async Task<bool> UpdateShippingStatusAsync(int orderId, OrderStatus status)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null) return false;

        if (!OrderStateMachine.IsShippingTransitionAllowed(order.OrderStatus, status))
            throw new InvalidOrderTransitionException(
                $"Shipping transition from {order.OrderStatus} to {status} is not allowed.");

        order.OrderStatus = status;
        if (status == OrderStatus.Delivered)
        {
            order.DeleviredDate = DateTime.UtcNow;
            if (order.PaymentStatus != PaymentStatus.Paid)
            {
                order.PaymentStatus = PaymentStatus.Paid;
                order.PaidAt = DateTime.UtcNow;
            }
        }

        _unitOfWork.Repository<Order>().Update(order);
        var result = await _unitOfWork.SaveChangesAsync();

        if (result > 0)
        {
            await _notificationService.SendOrderStatusNotificationAsync(order, status);

            if (status == OrderStatus.Delivered)
            {
                if (order.IsFinancialCalculated)
                {
                    await _financeService.UpdateSettlementsOnDeliveryAsync(order.Id);
                }
                else if (order.PaymentStatus == PaymentStatus.Paid)
                {
                    await _financeService.CalculateAndCreateSettlementsAsync(order);
                    await _financeService.UpdateSettlementsOnDeliveryAsync(order.Id);
                }

                if (order.PaymentStatus == PaymentStatus.Paid)
                {
                    await _notificationService.SendPaymentNotificationAsync(order, PaymentStatus.Paid);
                }
            }

            return true;
        }

        return false;
    }

    public async Task<bool> UpdatePaymentToPaidOnDeliveryAsync(int orderId)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null) return false;

        if (order.OrderStatus != OrderStatus.Delivered)
            throw new InvalidOrderTransitionException(
                "Payment cannot be updated to paid until order is delivered.");

        if (order.PaymentStatus == PaymentStatus.Paid) return true;

        order.PaymentStatus = PaymentStatus.Paid;
        order.PaidAt = DateTime.UtcNow;

        _unitOfWork.Repository<Order>().Update(order);
        var result = await _unitOfWork.SaveChangesAsync();

        if (result > 0)
        {
            await _financeService.CalculateAndCreateSettlementsAsync(order);

            if (order.OrderStatus == OrderStatus.Delivered)
            {
                await _financeService.UpdateSettlementsOnDeliveryAsync(order.Id);
            }

            await _notificationService.SendPaymentNotificationAsync(order, PaymentStatus.Paid);
            return true;
        }

        return false;
    }

    public async Task<UserOrdersResDto> GetUserOrdersAsync(string userId)
    {
        var orders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.UserId == userId)
            .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Images)
            .ToListAsync();

        var response = new UserOrdersResDto();

        foreach (var order in orders)
        {
            var items = order.OrderProducts.Select(op => new OrderItemImageDto
            {
                ProductName = op.Product.Name,
                ProductId = op.ProductId,
                ProductImage = ResolveImageUrl(op.Product.Images?.FirstOrDefault()?.Url),
                Price = op.FinalPrice,
                Quantity = op.Quantity
            }).ToList();

            var dto = new OrderResDto
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                TotalAmount = order.TotalAmount,
                OrderStatus = order.OrderStatus,
                PaymentStatus = order.PaymentStatus,
                Items = items
            };

            if (order.OrderStatus == OrderStatus.Delivered)
            {
                response.Completed.Add(dto);
            }
            else if (order.OrderStatus == OrderStatus.Cancelled)
            {
                response.Issues.Add(dto);
            }
            else
            {
                response.Active.Add(dto);
            }
        }

        return response;
    }

    public async Task<OrderDetailResDto?> GetOrderByIdAsync(string userId, int orderId)
    {
        var order = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.Id == orderId && o.UserId == userId)
            .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Images)
            .FirstOrDefaultAsync();

        if (order == null) return null;

        return new OrderDetailResDto
        {
            Id = order.Id,
            CreatedAt = order.CreatedAt,
            OrderStatus = order.OrderStatus,
            TrackingNumber = order.Tracking?.TrackingNumber,
            OrderInfo = new OrderInfoResDto
            {
                ShippingCity = order.ShippingCity,
                ShippingCountry = order.ShippingCountry,
                ShippingName = order.ShippingName,
                ShippingStreet = order.ShippingStreet,
                ShippingPostalCode = order.ShippingPostalCode,
                ShippingPhoneNumber = order.ShippingPhoneNumber,
                PaymentMethod = order.PaymentMethod,
                PaymentStatus = order.PaymentStatus,
                DeliveryMethod = order.DeliveryMethod,
                Discount = order.DiscountAmount,
                TotalAmount = order.TotalAmount
            },
            Items = order.OrderProducts.Select(op => new OrderItemResDto
            {
                Name = op.Product.Name,
                Color = op.Color,
                Description = op.Product.Description,
                ProductMediaUrls = (op.ProductMediaUrls?.Any() == true
                    ? op.ProductMediaUrls
                    : op.Product.Images?.Select(i => i.Url).ToList()
                )?.Select(u => ResolveImageUrl(u)).ToList() ?? new List<string>(),
                Size = op.Size,
                Quantity = op.Quantity,
                Price = op.FinalPrice
            }).ToList()
        };
    }

    public async Task<CreateOrderRes> CreateOrderAsync(string userId, CreateOrderReq request)
    {
        var address = await ResolveAddressAsync(userId, request);
        var cart = _cartCache.GetCart(userId);
        if (cart == null || cart.ProductCarts == null || !cart.ProductCarts.Any())
            throw new BadRequestException(new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "Cart",
                    En = "Cart is empty",
                    Ar = "عربة التسوق فارغة"
                }
            });

        var filteredItems = request.BrandId.HasValue
            ? cart.ProductCarts.Where(p => p.BrandId == request.BrandId.Value).ToList()
            : cart.ProductCarts.ToList();

        if (!filteredItems.Any())
            throw new BadRequestException(new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "Cart",
                    En = "Cart is empty for selected brand",
                    Ar = "عربة التسوق فارغة للعلامة التجارية المحددة"
                }
            });

        var brandCart = new Cart { ProductCarts = filteredItems };

        var discountCode = await ResolveDiscountCodeAsync(request.DiscountCode);
        var orderProducts = await BuildOrderProductsAsync(brandCart, discountCode?.DiscountValue);
        var subTotal = orderProducts.Sum(p => p.FinalPrice * p.Quantity);
        var shipping = CalculateShipping(request.DeliveryMethod);
        var discountAmount = subTotal > 0 ? orderProducts.Sum(p => p.AppliedDiscountCodeAmount * p.Quantity) : 0;
        var total = subTotal + shipping;

        var order = CreateOrderEntity(userId, address, request, orderProducts, total, discountAmount, discountCode?.Id);

        await _unitOfWork.Repository<Order>().AddAsync(order);

        if (discountCode != null)
        {
            discountCode.UsageCount++;
            _unitOfWork.Repository<DiscountCode>().Update(discountCode);
        }

        if (request.BrandId.HasValue)
            _cartCache.ClearCartBrand(userId, request.BrandId.Value);
        else
            _cartCache.ClearCart(userId);

        await _unitOfWork.SaveChangesAsync();

        return new CreateOrderRes
        {
            Id = order.Id,
            Status = order.OrderStatus,
            Total = order.TotalAmount,
            address = address
        };
    }

    private async Task<Address> ResolveAddressAsync(string userId, CreateOrderReq request)
    {
        if (request.Address != null)
        {
            var addr = request.Address;
            var address = new Address
            {
                UserId = userId,
                Name = string.IsNullOrWhiteSpace(addr.Name) ? "N/A" : addr.Name,
                LastName = string.IsNullOrWhiteSpace(addr.ShippingLastName) ? "N/A" : addr.ShippingLastName,
                Postcode = string.IsNullOrWhiteSpace(addr.PostalCode) ? "N/A" : addr.PostalCode,
                Country = string.IsNullOrWhiteSpace(addr.Country) ? "N/A" : addr.Country,
                City = string.IsNullOrWhiteSpace(addr.City) ? "N/A" : addr.City,
                Street = string.IsNullOrWhiteSpace(addr.Street) ? "N/A" : addr.Street,
                PhoneNumber = string.IsNullOrWhiteSpace(addr.PhoneNumber) ? "N/A" : addr.PhoneNumber,
                Apartment = string.IsNullOrWhiteSpace(addr.ShippingApartment) ? "N/A" : addr.ShippingApartment,
                Floor = string.IsNullOrWhiteSpace(addr.ShippingFloor) ? "N/A" : addr.ShippingFloor,
                Building = string.IsNullOrWhiteSpace(addr.ShippingBuilding) ? "N/A" : addr.ShippingBuilding
            };

            if (request.Address.SaveAddress)
            {
                if (request.Address.SetAsDefault)
                {
                    var oldDefault = await _unitOfWork.Repository<Address>()
                        .FirstOrDefaultAsync(a => a.UserId == userId && a.IsDefault);

                    if (oldDefault != null)
                        oldDefault.IsDefault = false;

                    address.IsDefault = true;
                }

                await _unitOfWork.Repository<Address>().AddAsync(address);
            }

            return address;
        }

        if (request.AddressId.HasValue)
        {
            var existingAddress = await _unitOfWork.Repository<Address>()
                .GetByIdAsync(request.AddressId.Value);

            if (existingAddress == null || existingAddress.UserId != userId)
                throw new NotFoundException("Address not found");

            return existingAddress;
        }

        throw new BadRequestException(new List<ValidationError>
        {
            new ValidationError
            {
                Field = "Address",
                En = "Address is required",
                Ar = "العنوان مطلوب"
            }
        });
    }

    private async Task<List<OrderProduct>> BuildOrderProductsAsync(Cart cart, decimal? discountCodePercentage = null)
    {
        var productIds = cart.ProductCarts.Select(c => c.ProductId).ToList();

        var spec = new ProductsForOrderSpec(productIds);

        var products = await _unitOfWork.Repository<Product>()
            .GetAllWithSpecAsync(spec);

        var productDictionary = products.ToDictionary(p => p.Id);

        var orderProducts = new List<OrderProduct>();

        foreach (var cartItem in cart.ProductCarts)
        {
            if (!productDictionary.TryGetValue(cartItem.ProductId, out var product))
                throw new NotFoundException($"Product with id {cartItem.ProductId} not found");

            var colorMapping = product.AvailableColors
                .FirstOrDefault(c => string.Equals(
                    c.ProductColor.Name,
                    cartItem.Color,
                    StringComparison.OrdinalIgnoreCase));

            if (colorMapping == null)
                throw new BadRequestException(new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "Color",
                        En = $"Color {cartItem.Color} not available",
                        Ar = $"اللون {cartItem.Color} غير متوفر"
                    }
                });

            var sizeMapping = colorMapping.AvailableSizes
                .FirstOrDefault(s => s.ProductSize.Size == cartItem.Size);

            if (sizeMapping == null)
                throw new BadRequestException(new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "Size",
                        En = $"Size {cartItem.Size} not available",
                        Ar = $"المقاس {cartItem.Size} غير متوفر"
                    }
                });

            if (sizeMapping.Quantity < cartItem.Quantity)
                throw new BadRequestException(new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "Stock",
                        En = $"Not enough stock for {product.Name}",
                        Ar = $"الكمية غير متوفرة للمنتج {product.Name}"
                    }
                });

            sizeMapping.Quantity -= cartItem.Quantity;

            var (finalPrice, appliedDiscountAmount) = CalculateFinalPrice(product, discountCodePercentage);

            orderProducts.Add(new OrderProduct
            {
                ProductId = product.Id,
                ProductName = product.Name,
                BrandId = product.BrandId,
                Quantity = cartItem.Quantity,
                FinalPrice = finalPrice,
                AppliedDiscountCodeAmount = appliedDiscountAmount,
                Color = cartItem.Color,
                Size = cartItem.Size,
                ProductMediaUrls = product.Images?.Select(i => i.Url).ToList() ?? new List<string>()
            });
        }

        return orderProducts;
    }

    private (decimal FinalPrice, decimal AppliedDiscountCodeAmount) CalculateFinalPrice(Product product, decimal? discountCodePercentage)
    {
        decimal finalPrice = product.Price;
        decimal appliedDiscountCodeAmount = 0;

        if (product.DiscountPercentage.HasValue && product.DiscountPercentage > 0)
        {
            var discountAmount = product.Price * (product.DiscountPercentage.Value / 100m);
            finalPrice = product.Price - discountAmount;
        }
        else if (discountCodePercentage.HasValue && discountCodePercentage > 0)
        {
            appliedDiscountCodeAmount = product.Price * (discountCodePercentage.Value / 100m);
            finalPrice = product.Price - appliedDiscountCodeAmount;
        }

        return (finalPrice, appliedDiscountCodeAmount);
    }

    private Order CreateOrderEntity(
        string userId,
        Address address,
        CreateOrderReq request,
        List<OrderProduct> orderProducts,
        decimal total,
        decimal discountAmount,
        int? discountCodeId)
    {
        var paymentStatus = request.PaymentMethod switch
        {
            PaymentMethod.CashOnDelivery => PaymentStatus.Pending,
            _ => PaymentStatus.Pending
        };

        return new Order
        {
            OrderStatus = OrderStatus.Pending,
            PaymentStatus = paymentStatus,
            PaymentMethod = request.PaymentMethod,
            DeliveryMethod = request.DeliveryMethod,
            TotalAmount = total,
            UserId = userId,

            ShippingName = address.Name,
            ShippingLastName = address.LastName,
            ShippingCity = address.City,
            ShippingCountry = address.Country,
            ShippingPostalCode = address.Postcode,
            ShippingStreet = address.Street,
            ShippingPhoneNumber = address.PhoneNumber,
            ShippingBuilding = address.Building,
            ShippingFloor = address.Floor,
            ShippingApartment = address.Apartment,
            DiscountAmount = discountAmount,
            DiscountCodeId = discountCodeId,

            OrderProducts = orderProducts
        };
    }

    public async Task<OrderSummaryResDto> GetOrderSummaryAsync(string userId, CreateOrderReq request)
    {
        var address = await ResolveAddressAsync(userId, request);
        var cart = _cartCache.GetCart(userId);

        if (cart == null || cart.ProductCarts == null || !cart.ProductCarts.Any())
            throw new BadRequestException(new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "Cart",
                    En = "Cart is empty",
                    Ar = "عربة التسوق فارغة"
                }
            });

        var filteredItems = request.BrandId.HasValue
            ? cart.ProductCarts.Where(p => p.BrandId == request.BrandId.Value).ToList()
            : cart.ProductCarts.ToList();

        if (!filteredItems.Any())
            throw new BadRequestException(new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "Cart",
                    En = "Cart is empty for selected brand",
                    Ar = "عربة التسوق فارغة للعلامة التجارية المحددة"
                }
            });

        var brandCart = new Cart { ProductCarts = filteredItems };

        var discountCode = await ResolveDiscountCodeAsync(request.DiscountCode);
        var orderProducts = await BuildOrderProductsAsync(brandCart, discountCode?.DiscountValue);
        var subTotal = orderProducts.Sum(p => p.FinalPrice * p.Quantity);
        var shipping = CalculateShipping(request.DeliveryMethod);
        var discountAmount = subTotal > 0 ? orderProducts.Sum(p => p.AppliedDiscountCodeAmount * p.Quantity) : 0;
        var total = subTotal + shipping;

        var items = orderProducts.Select(op => new OrderSummaryItemResDto
        {
            ProductId = op.ProductId.Value,
            ProductName = op.ProductName,
            Color = op.Color,
            Size = op.Size,
            Quantity = op.Quantity,
            UnitPrice = op.FinalPrice,
            DiscountPercentage = null,
            PriceAfterDiscount = op.FinalPrice,
            TotalItemPrice = op.FinalPrice * op.Quantity,
            ProductImages = op.ProductMediaUrls ?? new List<string>()
        }).ToList();

        var summary = new OrderSummarySummaryResDto
        {
            ShippingAddress = new OrderAddressSummaryResDto
            {
                Name = address.Name,
                LastName = address.LastName,
                Street = address.Street,
                Building = address.Building,
                Floor = address.Floor,
                Apartment = address.Apartment,
                City = address.City,
                Country = address.Country,
                PostalCode = address.Postcode,
                PhoneNumber = address.PhoneNumber
            },
            SubTotal = subTotal,
            DiscountAmount = discountAmount,
            ShippingPrice = shipping,
            DeliveryMethod = request.DeliveryMethod.ToString(),
            PaymentMethod = request.PaymentMethod.ToString(),
            Total = total
        };

        return new OrderSummaryResDto
        {
            Items = items,
            Summary = summary
        };
    }

    public async Task<BrandOrdersResDto> GetBrandOrdersAsync(string userId)
    {
        var brand = await _unitOfWork.Repository<Brand>()
            .FirstOrDefaultAsync(b => b.UserId == userId);

        if (brand == null)
            return new BrandOrdersResDto();

        var brandOrderProducts = await _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
            .Where(op => op.BrandId == brand.Id)
            .Include(op => op.Order)
                .ThenInclude(o => o.User)
            .OrderByDescending(op => op.Order.CreatedAt)
            .ToListAsync();

        var visibleOrderProducts = brandOrderProducts
            .Where(op => op.Order.PaymentStatus != PaymentStatus.Failed && op.Order.PaymentStatus != PaymentStatus.Pending)
            .ToList();

        var grouped = visibleOrderProducts
            .GroupBy(op => op.OrderId)
            .Select(g =>
            {
                var order = g.First().Order;
                return new BrandOrderDto
                {
                    OrderId = g.Key,
                    CreatedAt = order.CreatedAt,
                    CustomerName = order.User?.DisplayName ?? "Unknown",
                    ItemCount = g.Sum(op => op.Quantity),
                    TotalAmount = order.TotalAmount,
                    Status = order.OrderStatus,
                    PaymentStatus = order.PaymentStatus,
                    Items = g.Select(op => new BrandOrderItemDto
                    {
                        ProductName = op.ProductName,
                        ProductImage = op.ProductMediaUrls != null && op.ProductMediaUrls.Count > 0 ? op.ProductMediaUrls[0] : null,
                        Quantity = op.Quantity,
                        Price = op.FinalPrice,
                        Color = op.Color,
                        Size = op.Size.ToString()
                    }).ToList()
                };
            })
            .OrderByDescending(o => o.CreatedAt)
            .ToList();

        return new BrandOrdersResDto
        {
            Orders = grouped
        };
    }

    private async Task<DiscountCode?> ResolveDiscountCodeAsync(string? code)
    {
        if (string.IsNullOrWhiteSpace(code)) return null;

        var discountCode = await _unitOfWork.Repository<DiscountCode>()
            .FirstOrDefaultAsync(d => d.Code == code);

        if (discountCode == null)
            throw new BadRequestException("Invalid discount code");

        if (discountCode.ExpirationDate < DateTime.UtcNow)
            throw new BadRequestException("Discount code has expired");

        return discountCode;
    }
}
