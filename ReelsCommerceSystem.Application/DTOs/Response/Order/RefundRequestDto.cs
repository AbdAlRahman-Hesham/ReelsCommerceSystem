using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class RefundRequestDto
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = default!;
    public string CustomerEmail { get; set; } = default!;
    public decimal TotalAmount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime CancellationRequestedAt { get; set; }
    public int ItemCount { get; set; }
    public List<string> ProductNames { get; set; } = new();
}
