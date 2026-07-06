namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class AdminBrandFinanceSummaryDto
{
    public int BrandId { get; set; }
    public string BrandName { get; set; } = null!;
    public decimal PendingBalance { get; set; }
    public decimal AvailableBalance { get; set; }
    public decimal PaidBalance { get; set; }
    public decimal TotalLifetime { get; set; }
}
