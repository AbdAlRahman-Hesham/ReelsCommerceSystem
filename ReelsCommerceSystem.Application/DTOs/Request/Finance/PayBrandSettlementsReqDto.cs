namespace ReelsCommerceSystem.Application.DTOs.Request.Finance;

public class PayBrandSettlementsReqDto
{
    public List<int> SettlementIds { get; set; } = new();
    public int? WithdrawalRequestId { get; set; }
    public string? Reference { get; set; }
    public string? Notes { get; set; }
}
