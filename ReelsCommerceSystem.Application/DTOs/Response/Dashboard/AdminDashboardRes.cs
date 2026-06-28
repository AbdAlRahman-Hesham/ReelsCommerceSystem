using ReelsCommerceSystem.Application.DTOs.Response.Brand;

namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class AdminDashboardRes
{
    public int TotalBrands { get; set; }
    public int TotalUsers { get; set; }
    public int PendingRequests { get; set; }
    public int TotalOrders { get; set; }
    public decimal TotalRevenue { get; set; }
    public List<MonthlyGrowthDto> BrandGrowth { get; set; } = new();
    public List<MonthlyGrowthDto> UserGrowth { get; set; } = new();
    public List<MonthlyRevenueDto> RevenueTrend { get; set; } = new();
    public List<BrandDetailsDto> RecentBrandRequests { get; set; } = new();
    public List<TopBrandDto> TopBrands { get; set; } = new();
}

public class MonthlyGrowthDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Count { get; set; }
}

public class TopBrandDto
{
    public int BrandId { get; set; }
    public string BrandName { get; set; } = default!;
    public decimal TotalRevenue { get; set; }
    public int TotalOrders { get; set; }
}
