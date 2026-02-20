using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.OrderEntities;

public class OrderTracking : BaseEntity
{
    public string TrackingNumber { get; set; } = null!;
    public OrderStatus Status { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
}
