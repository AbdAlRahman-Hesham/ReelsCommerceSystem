using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Domain.Entities.FinanceEntities;

public class WithdrawalRequest : BaseEntity
{
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public decimal RequestedAmount { get; set; }
    public WithdrawalRequestStatus Status { get; set; } = WithdrawalRequestStatus.Pending;

    public DateTime? ApprovedAt { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? AdminId { get; set; }
    public string? PaymobTransferId { get; set; }
    public string? Notes { get; set; }
}
