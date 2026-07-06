using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class WithdrawalRequestDto
{
    public int Id { get; set; }
    public decimal RequestedAmount { get; set; }
    public WithdrawalRequestStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? PaymobTransferId { get; set; }
    public string? Notes { get; set; }
}
