using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.FinanceEntities;

public class FinancialAuditLog : BaseEntity
{
    public string Action { get; set; } = null!;
    public string EntityType { get; set; } = null!;
    public int EntityId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? PerformedBy { get; set; }
    public string? IpAddress { get; set; }
    public string? Notes { get; set; }
}
