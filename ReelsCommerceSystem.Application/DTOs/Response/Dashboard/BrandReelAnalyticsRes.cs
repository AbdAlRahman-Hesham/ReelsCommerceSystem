namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class BrandReelAnalyticsRes
{
    public int TotalViews { get; set; }
    public int TotalLikes { get; set; }
    public double ViewsGrowthPercentage { get; set; }
    public double LikesGrowthPercentage { get; set; }
    public ReelCountsDto ReelCounts { get; set; } = new();
    public List<MonthlyReelStatDto> MonthlyViews { get; set; } = new();
    public List<MonthlyReelStatDto> MonthlyLikes { get; set; } = new();
    public List<DailyReelStatDto> DailyViews { get; set; } = new();
    public List<DailyReelStatDto> DailyLikes { get; set; } = new();
    public List<YearlyReelStatDto> YearlyViews { get; set; } = new();
    public List<YearlyReelStatDto> YearlyLikes { get; set; } = new();
    public List<TopReelDto> TopViewedReels { get; set; } = new();
    public List<TopReelDto> TopLikedReels { get; set; } = new();
    public AudienceStatsDto AudienceStats { get; set; } = new();
    public List<MostViewedProductDto> MostViewedProducts { get; set; } = new();
    public DailyEngagementDto DailyEngagement { get; set; } = new();
    public double EngagementRate { get; set; }
    public int ProductViewsCount { get; set; }
}

public class MonthlyReelStatDto
{
    public string Month { get; set; } = default!;
    public int Count { get; set; }
}

public class AudienceStatsDto
{
    public int FollowersCount { get; set; }
    public int NonFollowersCount { get; set; }
    public int NewUsersCount { get; set; }
    public double FollowersGrowth { get; set; }
    public double NonFollowersGrowth { get; set; }
    public double NewUsersGrowth { get; set; }
}

public class MostViewedProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public int Views { get; set; }
}

public class DailyEngagementDto
{
    public List<int> DailyViews { get; set; } = new();
    public List<int> DailyLikes { get; set; } = new();
    public List<int> DailyComments { get; set; } = new();
    public int TotalViews { get; set; }
    public int TotalLikes { get; set; }
    public int TotalComments { get; set; }
}

public class DailyReelStatDto
{
    public string Date { get; set; } = default!;
    public int Count { get; set; }
}

public class YearlyReelStatDto
{
    public int Year { get; set; }
    public int Count { get; set; }
}
