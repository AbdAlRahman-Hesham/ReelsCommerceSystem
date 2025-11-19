using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.DisputeEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.OrderEntities;

public class Order: BaseEntity
{
    public DateTime OrderDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    public decimal TotalAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
   
    public string UserId { get; set; }

    public User User { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    public ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();


}
