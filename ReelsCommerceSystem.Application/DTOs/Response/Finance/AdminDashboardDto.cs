namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class AdminDashboardDto
{
    public decimal TotalPendingBrandBalance { get; set; }
    public decimal TotalAvailableBrandBalance { get; set; }
    public decimal TotalPaidBrandBalance { get; set; }
    public decimal TotalPendingShippingBalance { get; set; }
    public decimal TotalPaidShippingBalance { get; set; }
    public decimal PlatformTotalCommission { get; set; }
    public int OrdersWaitingSettlement { get; set; }
}
