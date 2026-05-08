using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;

namespace ReelsCommerceSystem.Domain.Entities.OrderEntities;

public class DiscountCode : BaseEntity
{
    public string Code { get; set; } = default!;
    public int UsageCount { get; set; } = 0;
    public DateTime ExpirationDate { get; set; }
    public decimal DiscountValue { get; set; } // Percentage, Max 50

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
