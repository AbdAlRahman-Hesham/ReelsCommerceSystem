using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICartCacheService _cartCache;
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

    public OrderService(IUnitOfWork unitOfWork, ICartCacheService cartCache)
    {
        _unitOfWork = unitOfWork;
        _cartCache = cartCache;
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

            if (order.OrderStatus == OrderStatus.Deliverd)
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

                    ShippingCity=o.ShippingCity,
                    ShippingCountry=o.ShippingCountry,
                    ShippingName=o.ShippingName,
                    ShippingStreet=o.ShippingStreet,
                    ShippingPostalCode=o.ShippingPostalCode,
                    ShippingPhoneNumber=o.ShippingPhoneNumber,
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
        Address address;

        if (request.Address != null)
        {
            // Use manual address, ignore AddressId
            address = new Address
            {
                UserId = userId,
                Name = request.Address.Name,
                Postcode = request.Address.PostalCode,
                Country = request.Address.Country,
                City = request.Address.City,
                Street = request.Address.Street,
                PhoneNumber = request.Address.PhoneNumber,
                IsDefault = request.Address.SetAsDefault
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
        }
        else if (request.AddressId.HasValue)
        {
            address = await _unitOfWork.Repository<Address>().GetByIdAsync(request.AddressId.Value);
            if (address == null || address.UserId != userId)
                throw new Exception("Invalid address");
        }
        else
        {
            throw new Exception("Address is required");
        }
        var cart = _cartCache.GetCart(userId);

        if (cart == null || cart.ProductCarts == null || !cart.ProductCarts.Any())
            throw new Exception("Cart is empty");

        var subTotal = cart.ProductCarts.Sum(x => x.Price * x.Quantity);
        var shipping = CalculateShipping(request.DeliveryMethod);
        var total = subTotal + shipping;

        var order = new Order
        {
            OrderStatus = OrderStatus.Pending,
            TotalAmount = total,
            PaymentStatus = PaymentStatus.Pending,
            PaymentMethod = request.PaymentMethod,
            UserId = userId,
            ShippingCity=address.City,
            ShippingCountry=address.Country,
            ShippingName=address.Name,
            ShippingPhoneNumber=address.PhoneNumber,
            ShippingPostalCode=address.Postcode,
            ShippingStreet=address.Street,

            DeliveryMethod = request.DeliveryMethod,
        };

        await _unitOfWork.Repository<Order>().AddAsync(order);
        await _unitOfWork.SaveChangesAsync();

        return new CreateOrderRes
        {
            Id = order.Id,
            Status = order.OrderStatus,
            Total = order.TotalAmount,
            address= address,
        };
    }
}
