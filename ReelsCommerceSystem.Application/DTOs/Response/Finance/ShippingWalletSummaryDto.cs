namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class ShippingWalletSummaryDto
{
    public decimal PendingBalance { get; set; }
    public decimal AvailableBalance { get; set; }
    public decimal PaidBalance { get; set; }
    public decimal TotalLifetimeEarnings { get; set; }
}
