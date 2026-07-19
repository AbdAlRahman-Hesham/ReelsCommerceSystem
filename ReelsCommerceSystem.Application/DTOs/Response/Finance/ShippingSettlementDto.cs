using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class ShippingSettlementDto
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string OrderReference { get; set; } = null!;
    public decimal Amount { get; set; }
    public ShippingSettlementStatus Status { get; set; }
    public string StatusString => Status.ToString();
    public DateTime? PaidAt { get; set; }
    public string? PaymentReference { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}
