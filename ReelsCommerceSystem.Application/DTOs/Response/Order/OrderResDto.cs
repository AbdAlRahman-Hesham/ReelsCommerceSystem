using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class OrderResDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public List<OrderItemImageDto> Items { get; set; } = new();
}

public class OrderItemImageDto
{
    public string ProductName { get; set; } = null!;
    public int? ProductId { get; set; }
    public string? ProductImage { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
