namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class AdminBrandFinanceDetailDto
{
    public AdminBrandFinanceSummaryDto Summary { get; set; } = null!;
    public List<BrandSettlementDto> Settlements { get; set; } = new();
    public List<WithdrawalRequestDto> WithdrawalHistory { get; set; } = new();
}
