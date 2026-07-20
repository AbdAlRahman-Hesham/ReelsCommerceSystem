namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class AdminShippingFinanceSummaryDto
{
    public int ShippingCompanyId { get; set; }
    public string ShippingCompanyName { get; set; } = null!;
    public decimal PendingBalance { get; set; }
    public decimal AvailableBalance { get; set; }
    public decimal PaidBalance { get; set; }
    public decimal TotalLifetime { get; set; }
}
