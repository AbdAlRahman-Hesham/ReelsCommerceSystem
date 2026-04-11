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
        var orders = await _unitOfWork.Repository<Order>().GetAllAsync();
        var userOrders = orders.Where(o => o.UserId == userId).ToList();

        var response = new UserOrdersResDto();

        foreach (var order in userOrders)
        {
            var dto = new OrderResDto
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                TotalAmount = order.TotalAmount,
                OrderStatus = order.OrderStatus,
                PaymentStatus = order.PaymentStatus
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
                    DeliveryMethod = o.DeliveryMethod,
                    Discount = o.DiscountAmount,
                    TotalAmount = o.TotalAmount
                },

                Items = o.OrderProducts.Select(op => new OrderItemResDto
                {
                    Name = op.Product.Name,
                    Color = op.Color,
                    Description = op.Product.Description,
                    ImageUrl = op.Product.MediaUrl,
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
        var orderProducts = await BuildOrderProductsAsync(cart);
        var subTotal = orderProducts.Sum(p => p.FinalPrice * p.Quantity);
        var shipping = CalculateShipping(request.DeliveryMethod);
        var total = subTotal + shipping;
        var order = CreateOrderEntity(userId, address, request, orderProducts, total);

        await _unitOfWork.Repository<Order>().AddAsync(order);

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
    private async Task<List<OrderProduct>> BuildOrderProductsAsync(Cart cart)
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

            var finalPrice = CalculateFinalPrice(product);

            orderProducts.Add(new OrderProduct
            {
                ProductId = product.Id,
                ProductName = product.Name,
                BrandId = product.BrandId,
                Quantity = cartItem.Quantity,
                FinalPrice = finalPrice,
                Color = cartItem.Color,
                Size = cartItem.Size
            });
        }

        return orderProducts;
    }
    private decimal CalculateFinalPrice(Product product)
    {
        if (product.DiscountPercentage.HasValue && product.DiscountPercentage > 0)
        {
            var discountAmount = product.Price * (product.DiscountPercentage.Value / 100m);
            return product.Price - discountAmount;
        }

        return product.Price;
    }
    private Order CreateOrderEntity(
    string userId,
    Address address,
    CreateOrderReq request,
    List<OrderProduct> orderProducts,
    decimal total)
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

            OrderProducts = orderProducts
        };
    }
}
