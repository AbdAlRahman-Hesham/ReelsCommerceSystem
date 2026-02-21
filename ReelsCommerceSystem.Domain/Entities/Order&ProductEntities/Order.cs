using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.OrderEntities;

public class Order: BaseEntity
{
    public DateTime? DeleviredDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    public decimal TotalAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;

    public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.NotSpecified;
    
    public string UserId { get; set; }
    public User User { get; set; }

    public int? AddressId { get; set; }
    public Address? Address { get; set; }

    public DeliveryMethod DeliveryMethod { get; set; }
    public decimal DiscountAmount { get; set; }

    public OrderTracking? Tracking { get; set; }

    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}


