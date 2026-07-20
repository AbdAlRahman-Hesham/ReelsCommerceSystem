namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class OrdersByRegionRes
{
    public int TotalOrders { get; set; }
    public List<RegionOrderCount> Regions { get; set; } = new();
}

public class RegionOrderCount
{
    public string City { get; set; } = string.Empty;
    public int OrderCount { get; set; }
}
