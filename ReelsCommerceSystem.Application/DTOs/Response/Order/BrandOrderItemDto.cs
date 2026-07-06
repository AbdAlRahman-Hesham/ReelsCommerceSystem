namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class BrandOrderItemDto
{
    public string ProductName { get; set; } = default!;
    public string? ProductImage { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string? Color { get; set; }
    public string? Size { get; set; }
}
