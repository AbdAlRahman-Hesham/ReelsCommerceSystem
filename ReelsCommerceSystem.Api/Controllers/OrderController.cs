using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Order;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;
using System.Security.Claims;
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

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody]CreateOrderReq request)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _orderService.CreateOrderAsync(userId, request);

        return Ok(result);
    }

    [HttpPut("{id}/status")]
    public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] OrderStatus newStatus)
    {
        var success = await _orderService.UpdateOrderStatusAsync(id, newStatus);
        if (!success)
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to update order status.", "فشل تحديث حالة الطلب."));

        return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Order status updated successfully."));
    }

    [HttpPost("Summary")]
    public async Task<IActionResult> GetOrderSummary([FromBody] CreateOrderReq request)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var summary = await _orderService.GetOrderSummaryAsync(userId, request);
        return Ok(ApiResponse<object>.SuccessResponse(summary, HttpStatusCode.OK, "Order summary retrieved successfully."));
    }

    [Authorize(Roles = SystemRoles.BrandOwner)]
    [HttpGet("brand-orders")]
    public async Task<IActionResult> GetBrandOrders()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _orderService.GetBrandOrdersAsync(userId);
        return Ok(ApiResponse<BrandOrdersResDto>.SuccessResponse(result, HttpStatusCode.OK, "Orders retrieved successfully."));
    }
}

