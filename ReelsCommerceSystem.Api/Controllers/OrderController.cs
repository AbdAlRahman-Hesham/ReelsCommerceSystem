using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Security.Claims;
using System.Net;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Api.Controllers;

[Authorize]
public class OrderController : AppBaseController
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("MyOrders")]
    public async Task<IActionResult> GetMyOrders()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var orders = await _orderService.GetUserOrdersAsync(userId);
        return Ok(ApiResponse<object>.SuccessResponse(orders, HttpStatusCode.OK, "Orders retrieved successfully."));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var order = await _orderService.GetOrderByIdAsync(userId, id);
        if (order == null)
            return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, "Order not found.", "الطلب غير موجود."));

        return Ok(ApiResponse<object>.SuccessResponse(order, HttpStatusCode.OK, "Order retrieved successfully."));
    }
}

