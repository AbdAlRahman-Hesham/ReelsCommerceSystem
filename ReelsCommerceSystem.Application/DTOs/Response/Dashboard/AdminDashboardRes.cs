using ReelsCommerceSystem.Application.DTOs.Response.Brand;

namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class AdminDashboardRes
{
    public int TotalBrands { get; set; }
    public int TotalUsers { get; set; }
    public int PendingRequests { get; set; }
    public int TotalOrders { get; set; }
    public decimal TotalRevenue { get; set; }
    public int TotalProducts { get; set; }
    public int TotalReels { get; set; }
    public int TotalReelViews { get; set; }
    public double EngagementRate { get; set; }
    public decimal BrandSalesRevenue { get; set; }
    public decimal DeliveryRevenue { get; set; }
    public decimal AdsRevenue { get; set; }
    public int ActiveBrands { get; set; }
    public int ActiveUsers { get; set; }
    public double RevenueGrowthPercentage { get; set; }
    public double OrdersGrowthPercentage { get; set; }
    public List<MonthlyGrowthDto> BrandGrowth { get; set; } = new();
    public List<MonthlyGrowthDto> UserGrowth { get; set; } = new();
    public List<MonthlyRevenueDto> RevenueTrend { get; set; } = new();
    public List<MonthlyGrowthDto> MonthlyOrdersTrend { get; set; } = new();
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
