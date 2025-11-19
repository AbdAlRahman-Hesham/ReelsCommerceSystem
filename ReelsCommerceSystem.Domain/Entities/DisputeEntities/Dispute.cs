using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.DisputeEntities
{
    public class Dispute:BaseEntity
    {
        public string Reason { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DisputeStatus Status { get; set; } = DisputeStatus.Open;
        public string UserId { get; set; }
        public User User { get; set; } = null!;
        public  int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
