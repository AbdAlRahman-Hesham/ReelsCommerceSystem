using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Domain.Entities.FinanceEntities;

public class BrandSettlement : BaseEntity
{
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public decimal GrossAmount { get; set; }
    public decimal PlatformCommission { get; set; }
    public decimal NetAmount { get; set; }

    public SettlementStatus Status { get; set; } = SettlementStatus.Pending;
    public DateTime? AvailableAt { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? PaidByAdminId { get; set; }
    public string? PaymentReference { get; set; }
    public string? Notes { get; set; }

    public string? TransferId { get; set; }
    public string? TransferRawResponse { get; set; }
    public int RetryCount { get; set; }
    public DateTime? LastTransferAttemptAt { get; set; }
}
