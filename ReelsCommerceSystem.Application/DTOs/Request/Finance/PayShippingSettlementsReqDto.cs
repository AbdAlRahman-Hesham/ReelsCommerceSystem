namespace ReelsCommerceSystem.Application.DTOs.Request.Finance;

public class PayShippingSettlementsReqDto
{
    public List<int> SettlementIds { get; set; } = new();
    public string? Reference { get; set; }
    public string? Notes { get; set; }
}
