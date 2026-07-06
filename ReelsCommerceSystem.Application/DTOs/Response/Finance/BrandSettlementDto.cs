using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class BrandSettlementDto
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string OrderReference { get; set; } = null!;
    public decimal GrossAmount { get; set; }
    public decimal PlatformCommission { get; set; }
    public decimal NetAmount { get; set; }
    public SettlementStatus Status { get; set; }
    public DateTime? AvailableAt { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? TransferId { get; set; }
    public string? PaymentReference { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}
