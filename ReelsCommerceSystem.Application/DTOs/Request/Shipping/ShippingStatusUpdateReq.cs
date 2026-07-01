using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Request.Shipping;

public class ShippingStatusUpdateReq
{
    public int OrderId { get; set; }
    public OrderStatus Status { get; set; }
}
