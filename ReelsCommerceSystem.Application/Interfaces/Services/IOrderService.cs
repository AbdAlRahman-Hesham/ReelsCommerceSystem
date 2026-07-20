using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Shipping;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOrderService
{
    Task<UserOrdersResDto> GetUserOrdersAsync(string userId);
    Task<OrderDetailResDto?> GetOrderByIdAsync(string userId, int orderId);
    Task<CreateOrderRes> CreateOrderAsync(string userId, CreateOrderReq request);
    Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus, string userRole, string userId);
    Task<OrderSummaryResDto> GetOrderSummaryAsync(string userId, CreateOrderReq request);
    Task<BrandOrdersResDto> GetBrandOrdersAsync(string userId);

    Task CancelOrderAsync(int orderId, string userId, string userRole);
    Task ProcessRefundAsync(int orderId, string adminId);
    Task<List<RefundRequestDto>> GetRefundRequestsAsync();

    Task<List<ReadyToShipOrderDto>> GetReadyToShipOrdersAsync();
    Task<bool> UpdateShippingStatusAsync(int orderId, OrderStatus status);
    Task<bool> UpdatePaymentToPaidOnDeliveryAsync(int orderId);
}
