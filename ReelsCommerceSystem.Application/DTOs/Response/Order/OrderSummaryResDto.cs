using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class OrderSummaryResDto
{
    public List<OrderSummaryItemResDto> Items { get; set; } = new();
    public OrderSummarySummaryResDto Summary { get; set; } = new();
}

public class OrderSummaryItemResDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Color { get; set; }
    public Size Size { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public decimal PriceAfterDiscount { get; set; }
    public decimal TotalItemPrice { get; set; }
    public List<string>? ProductImages { get; set; } = new();
}

public class OrderSummarySummaryResDto
{
    public OrderAddressSummaryResDto ShippingAddress { get; set; } = new();
    public decimal SubTotal { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal ShippingPrice { get; set; }
    public string DeliveryMethod { get; set; } = null!;
    public string PaymentMethod { get; set; } = null!;
    public decimal Total { get; set; }
}

public class OrderAddressSummaryResDto
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Street { get; set; }
    public string? Building { get; set; }
    public string? Floor { get; set; }
    public string? Apartment { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? PhoneNumber { get; set; }
}
