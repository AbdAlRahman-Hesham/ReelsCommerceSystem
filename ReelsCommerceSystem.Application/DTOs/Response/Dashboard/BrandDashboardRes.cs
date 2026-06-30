namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class BrandDashboardRes
{
    public int TotalProducts { get; set; }
    public int TotalOrders { get; set; }
    public decimal TotalRevenue { get; set; }
    public decimal MonthlyRevenue { get; set; }
    public double RevenueGrowthPercentage { get; set; }
    public double OrdersGrowthPercentage { get; set; }
    public int ActiveCustomers { get; set; }
    public double CustomersGrowthPercentage { get; set; }
    public double SalesGrowthPercentage { get; set; }
    public ReelCountsDto ReelCounts { get; set; } = new();
    public PostCountsDto PostCounts { get; set; } = new();
    public List<RecentOrderDto> RecentOrders { get; set; } = new();
    public List<MonthlyRevenueDto> RevenueTrend { get; set; } = new();
    public List<TopProductDto> TopProducts { get; set; } = new();
    public int TotalReelViews { get; set; }
    public int TotalReelLikes { get; set; }
    public List<TopReelDto> TopViewedReels { get; set; } = new();
    public List<TopReelDto> TopLikedReels { get; set; } = new();
}

public class ReelCountsDto
{
    public int All { get; set; }
    public int Published { get; set; }
    public int Draft { get; set; }
}

public class PostCountsDto
{
    public int All { get; set; }
    public int Published { get; set; }
    public int Draft { get; set; }
}
