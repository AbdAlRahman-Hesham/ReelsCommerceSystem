using ReelsCommerceSystem.Application.DTOs.Response.Order;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOrderService
{
    Task<UserOrdersResDto> GetUserOrdersAsync(string userId);
    Task<OrderDetailResDto?> GetOrderByIdAsync(string userId, int orderId);
}

