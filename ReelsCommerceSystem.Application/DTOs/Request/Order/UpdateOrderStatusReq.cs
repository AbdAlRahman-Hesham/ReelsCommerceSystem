using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Request.Order;

public class UpdateOrderStatusReq
{
    public OrderStatus NewStatus { get; set; }
}
