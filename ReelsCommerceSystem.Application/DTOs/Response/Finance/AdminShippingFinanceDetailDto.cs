namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class AdminShippingFinanceDetailDto
{
    public AdminShippingFinanceSummaryDto Summary { get; set; } = null!;
    public List<ShippingSettlementDto> Settlements { get; set; } = new();
}
