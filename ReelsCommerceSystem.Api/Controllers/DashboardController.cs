using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Response.Dashboard;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

[Authorize]
public class DashboardController : AppBaseController
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [Authorize(Roles = SystemRoles.BrandOwner)]
    [HttpGet("brand-stats")]
    public async Task<ActionResult<ApiResponse<BrandDashboardRes>>> GetBrandDashboard()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _dashboardService.GetBrandDashboardAsync(userId);

        return Ok(ApiResponse<BrandDashboardRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            "Brand dashboard data retrieved",
            "تم جلب بيانات لوحة التحكم"
        ));
    }

    [Authorize(Roles = SystemRoles.BrandOwner)]
    [HttpGet("brand-reel-analytics")]
    public async Task<ActionResult<ApiResponse<BrandReelAnalyticsRes>>> GetBrandReelAnalytics()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _dashboardService.GetBrandReelAnalyticsAsync(userId);

        return Ok(ApiResponse<BrandReelAnalyticsRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            "Brand reel analytics data retrieved",
            "تم جلب بيانات تحليلات الريلز"
        ));
    }

    [Authorize(Roles = SystemRoles.Admin)]
    [HttpGet("admin-stats")]
    public async Task<ActionResult<ApiResponse<AdminDashboardRes>>> GetAdminDashboard()
    {
        var result = await _dashboardService.GetAdminDashboardAsync();

        return Ok(ApiResponse<AdminDashboardRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            "Admin dashboard data retrieved",
            "تم جلب بيانات لوحة تحكم الأدمن"
        ));
    }
}
