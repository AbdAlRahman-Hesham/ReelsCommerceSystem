namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class OrderStatusOverviewDto
{
    public OrderStatusCounts ThisWeek { get; set; } = new();
    public OrderStatusCounts ThisMonth { get; set; } = new();
    public OrderStatusCounts ThisYear { get; set; } = new();
}

public class OrderStatusCounts
{
    public int Pending { get; set; }
    public int Processing { get; set; }
    public int Preparing { get; set; }
    public int Packed { get; set; }
    public int Shipped { get; set; }
    public int Delivered { get; set; }
    public int Cancelled { get; set; }
    public int PendingCancellation { get; set; }
}
