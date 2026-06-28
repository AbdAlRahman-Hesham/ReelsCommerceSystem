namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class TopProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public int TotalSold { get; set; }
    public decimal Revenue { get; set; }
}
