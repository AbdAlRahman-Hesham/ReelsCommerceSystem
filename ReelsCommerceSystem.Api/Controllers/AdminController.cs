using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Admin;
using ReelsCommerceSystem.Application.DTOs.Response.Admin;
using ReelsCommerceSystem.Application.Exceptions;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/admin")]
[ApiController]
public class AdminController : AppBaseController
{
    private readonly IAdminService _adminService;
    private readonly IOrderService _orderService;

    public AdminController(IAdminService adminService, IOrderService orderService)
    {
        _adminService = adminService;
        _orderService = orderService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<ApiResponse<AdminLoginResDto>>> Login([FromBody] AdminLoginReqDto dto)
    {
        var result = await _adminService.LoginAsync(dto);
        return StatusCode(result.StatusCode, result);
    }

    [Authorize(Roles = SystemRoles.Admin)]
    [HttpPost("orders/{orderId}/refund")]
    public async Task<IActionResult> ProcessRefund(int orderId)
    {
        var adminId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(adminId))
            return Unauthorized();

        try
        {
            await _orderService.ProcessRefundAsync(orderId, adminId);
            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Refund processed successfully.", "تمت معالجة الاسترداد بنجاح."));
        }
        catch (NotFoundException ex)
        {
            return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, ex.Message, "الطلب غير موجود."));
        }
        catch (InvalidOrderTransitionException ex)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, ex.Message, "لا يمكن استرداد الطلب."));
        }
    }
}
