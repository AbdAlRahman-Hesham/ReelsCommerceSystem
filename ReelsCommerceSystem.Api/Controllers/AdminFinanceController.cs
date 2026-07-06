using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/admin/finance")]
[Authorize(Roles = SystemRoles.Admin)]
public class AdminFinanceController : AppBaseController
{
    private readonly IFinanceService _financeService;

    public AdminFinanceController(IFinanceService financeService)
    {
        _financeService = financeService;
    }

    [HttpGet("dashboard")]
    public async Task<IActionResult> GetDashboard()
    {
        var data = await _financeService.GetAdminDashboardAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("brands")]
    public async Task<IActionResult> GetBrandsSummary()
    {
        var data = await _financeService.GetAdminBrandFinanceSummaryAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("brands/{brandId}")]
    public async Task<IActionResult> GetBrandDetail(int brandId)
    {
        var data = await _financeService.GetAdminBrandFinanceDetailAsync(brandId);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpPost("brands/pay")]
    public async Task<IActionResult> PayBrandSettlements([FromBody] PayBrandSettlementsReqDto request)
    {
        var adminId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "unknown";
        var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();

        await _financeService.PayBrandSettlementsAsync(adminId, request, ipAddress);
        return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Payment processed successfully", "تم معالجة الدفع بنجاح"));
    }

    [HttpGet("shipping")]
    public async Task<IActionResult> GetShippingSummary()
    {
        var data = await _financeService.GetAdminShippingFinanceSummaryAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("shipping/{companyId}")]
    public async Task<IActionResult> GetShippingDetail(int companyId)
    {
        var data = await _financeService.GetAdminShippingFinanceDetailAsync(companyId);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpPost("shipping/pay")]
    public async Task<IActionResult> PayShippingSettlements([FromBody] PayShippingSettlementsReqDto request)
    {
        var adminId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "unknown";
        var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();

        await _financeService.PayShippingSettlementsAsync(adminId, request, ipAddress);
        return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Payment processed successfully", "تم معالجة الدفع بنجاح"));
    }

    [HttpGet("policy")]
    public async Task<IActionResult> GetPolicy()
    {
        var data = await _financeService.GetAdminPolicyAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }
}
