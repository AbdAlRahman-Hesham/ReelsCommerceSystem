using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class OrderDetailResDto
{
    public int Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public string? TrackingNumber { get; set; }
    
    public List<OrderItemResDto> Items { get; set; } = new List<OrderItemResDto>();
    
    public OrderInfoResDto OrderInfo { get; set; }
}

public class OrderItemResDto
{
    public string? Name { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
    //public string? ImageUrl { get; set; }
    public List<string>? ProductMediaUrls { get; set; } = new();
    public Size Size { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class OrderInfoResDto
{
    public string? ShippingName { get; set; }
    public string? ShippingStreet { get; set; }
    public string? ShippingCity { get; set; }
    public string? ShippingCountry { get; set; }
    public string? ShippingPostalCode { get; set; }
    public string? ShippingPhoneNumber { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalAmount { get; set; }
}

