using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.ShippingCompanyEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Domain.Entities.FinanceEntities;

public class ShippingSettlement : BaseEntity
{
    public int ShippingCompanyId { get; set; }
    public ShippingCompany ShippingCompany { get; set; } = null!;

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public decimal Amount { get; set; }

    public ShippingSettlementStatus Status { get; set; } = ShippingSettlementStatus.Pending;
    public DateTime? PaidAt { get; set; }
    public string? PaidByAdminId { get; set; }
    public string? PaymentReference { get; set; }
    public string? Notes { get; set; }
}
