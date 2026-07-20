using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Shipping;
using ReelsCommerceSystem.Application.Exceptions;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/shipping")]
[ApiController]
public class ShippingController : AppBaseController
{
    private readonly IOrderService _orderService;

    public ShippingController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("ready-to-ship")]
    public async Task<IActionResult> GetReadyToShipOrders()
    {
        var orders = await _orderService.GetReadyToShipOrdersAsync();
        return Ok(ApiResponse<object>.SuccessResponse(orders, HttpStatusCode.OK, "Ready to ship orders retrieved."));
    }

    [HttpPut("update-status")]
    public async Task<IActionResult> UpdateShippingStatus([FromBody] ShippingStatusUpdateReq request)
    {
        try
        {
            var success = await _orderService.UpdateShippingStatusAsync(request.OrderId, request.Status);
            if (!success)
                return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, "Order not found.", "الطلب غير موجود."));

            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Shipping status updated."));
        }
        catch (InvalidOrderTransitionException ex)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, ex.Message, "حالة الشحن لا تسمح بهذا التغيير."));
        }
    }

    [HttpPut("update-payment-to-paid")]
    public async Task<IActionResult> UpdatePaymentToPaid([FromBody] ShippingPaymentUpdateReq request)
    {
        try
        {
            var success = await _orderService.UpdatePaymentToPaidOnDeliveryAsync(request.OrderId);
            if (!success)
                return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, "Order not found.", "الطلب غير موجود."));

            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Payment status updated to paid."));
        }
        catch (InvalidOrderTransitionException ex)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, ex.Message, "لا يمكن تحديث حالة الدفع."));
        }
    }
}
