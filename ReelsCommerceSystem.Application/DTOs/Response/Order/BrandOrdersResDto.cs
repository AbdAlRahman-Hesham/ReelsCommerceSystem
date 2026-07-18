using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class BrandOrdersResDto
{
    public List<BrandOrderDto> Orders { get; set; } = new();
}

public class BrandOrderDto
{
    public int OrderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CustomerName { get; set; } = default!;
    public int ItemCount { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public List<BrandOrderItemDto> Items { get; set; } = new();
}
