using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Response.Shipping;

public class ReadyToShipOrderDto
{
    public int OrderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalAmount { get; set; }
    public string ShippingName { get; set; } = null!;
    public string ShippingStreet { get; set; } = null!;
    public string ShippingCity { get; set; } = null!;
    public string ShippingCountry { get; set; } = null!;
    public string ShippingPostalCode { get; set; } = null!;
    public string ShippingPhoneNumber { get; set; } = null!;
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public List<ReadyToShipOrderItemDto> Items { get; set; } = new();
}

public class ReadyToShipOrderItemDto
{
    public string ProductName { get; set; } = null!;
    public int Quantity { get; set; }
}
