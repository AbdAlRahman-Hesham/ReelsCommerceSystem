using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Domain.Enums;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOrderService
{
    Task<UserOrdersResDto> GetUserOrdersAsync(string userId);
    Task<OrderDetailResDto?> GetOrderByIdAsync(string userId, int orderId);
    Task<CreateOrderRes> CreateOrderAsync(string userId, CreateOrderReq request);
    Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
}

