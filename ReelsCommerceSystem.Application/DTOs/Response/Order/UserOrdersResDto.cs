using System.Collections.Generic;

namespace ReelsCommerceSystem.Application.DTOs.Response.Order;

public class UserOrdersResDto
{
    public List<OrderResDto> Active { get; set; } = new();
    public List<OrderResDto> Completed { get; set; } = new();
    public List<OrderResDto> Issues { get; set; } = new();
}
