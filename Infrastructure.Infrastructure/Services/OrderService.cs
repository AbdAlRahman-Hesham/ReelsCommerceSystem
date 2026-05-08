using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;


namespace ReelsCommerceSystem.Infrastructure.Services;


public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICartCacheService _cartCache;
    private readonly INotificationService _notificationService;

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

    public OrderService(IUnitOfWork unitOfWork, ICartCacheService cartCache, INotificationService notificationService)
    {
        _unitOfWork = unitOfWork;
        _cartCache = cartCache;
        _notificationService = notificationService;
    }

    public async Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus)
    {
        var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);
        if (order == null) return false;

        if (order.OrderStatus == newStatus) return true; // No change needed

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
                ProductImage = op.Product.Images?.FirstOrDefault()?.Url,
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
                response.Active.Add(dto); // Pending, Processing, Shipped, Preparing, Packed
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
            .Select(o => new OrderDetailResDto
            {
                Id = o.Id,
                CreatedAt = o.CreatedAt,
                OrderStatus = o.OrderStatus,
                TrackingNumber = o.Tracking != null ? o.Tracking.TrackingNumber : null,
                OrderInfo = new OrderInfoResDto
                {

                    ShippingCity = o.ShippingCity,
                    ShippingCountry = o.ShippingCountry,
                    ShippingName = o.ShippingName,
                    ShippingStreet = o.ShippingStreet,
                    ShippingPostalCode = o.ShippingPostalCode,
                    ShippingPhoneNumber = o.ShippingPhoneNumber,
                    PaymentMethod = o.PaymentMethod,
                    PaymentStatus = o.PaymentStatus,
                    DeliveryMethod = o.DeliveryMethod,
                    Discount = o.DiscountAmount,
                    TotalAmount = o.TotalAmount
                },

                Items = o.OrderProducts.Select(op => new OrderItemResDto
                {
                    Name = op.Product.Name,
                    Color = op.Color,
                    Description = op.Product.Description,
                    ProductMediaUrls = op.ProductMediaUrls.ToList(),
                    Size = op.Size,
                    Quantity = op.Quantity,
                    Price = op.FinalPrice
                }).ToList()
            }).FirstOrDefaultAsync();

        return order;
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
        var discountCode = await ResolveDiscountCodeAsync(request.DiscountCode);
        var orderProducts = await BuildOrderProductsAsync(cart, discountCode?.DiscountValue);
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
            var address = new Address
            {
                UserId = userId,
                Name = request.Address.Name,
                LastName = request.Address.ShippingLastName,
                Postcode = request.Address.PostalCode,
                Country = request.Address.Country,
                City = request.Address.City,
                Street = request.Address.Street,
                PhoneNumber = request.Address.PhoneNumber,
                Apartment = request.Address.ShippingApartment,
                Floor = request.Address.ShippingFloor,
                Building = request.Address.ShippingBuilding
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
            var address = await _unitOfWork.Repository<Address>()
                .GetByIdAsync(request.AddressId.Value);

            if (address == null || address.UserId != userId)
                throw new NotFoundException("Address not found");

            return address;
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
        return new Order
        {
            OrderStatus = OrderStatus.Pending,
            PaymentStatus = PaymentStatus.Pending,
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

        var discountCode = await ResolveDiscountCodeAsync(request.DiscountCode);
        var orderProducts = await BuildOrderProductsAsync(cart, discountCode?.DiscountValue);
        var subTotal = orderProducts.Sum(p => p.FinalPrice * p.Quantity);
        var shipping = CalculateShipping(request.DeliveryMethod);
        var discountAmount = subTotal > 0 ? orderProducts.Sum(p => p.AppliedDiscountCodeAmount * p.Quantity) : 0;
        var total = subTotal + shipping;

        // Build items with pricing details
        var items = orderProducts.Select(op => new OrderSummaryItemResDto
        {
            ProductId = op.ProductId.Value,
            ProductName = op.ProductName,
            Color = op.Color,
            Size = op.Size,
            Quantity = op.Quantity,
            UnitPrice = op.FinalPrice,
            DiscountPercentage = null, // Will be calculated based on product if needed
            PriceAfterDiscount = op.FinalPrice,
            TotalItemPrice = op.FinalPrice * op.Quantity,
            ProductImages = op.ProductMediaUrls ?? new List<string>()
        }).ToList();

        // Build summary
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

