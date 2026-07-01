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
    private readonly IBrandPermissionService _brandPermissionService;

    public DashboardController(IDashboardService dashboardService, IBrandPermissionService brandPermissionService)
    {
        _dashboardService = dashboardService;
        _brandPermissionService = brandPermissionService;
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

    [HttpGet("brand-status")]
    public async Task<ActionResult<ApiResponse<object>>> GetCurrentBrandStatus()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var status = await _brandPermissionService.GetBrandStatusAsync(userId);
        var isBanned = await _brandPermissionService.IsBannedAsync(userId);

        return Ok(ApiResponse<object>.SuccessResponse(
            new { status = status ?? "NONE", isBanned },
            HttpStatusCode.OK,
            "Brand status retrieved",
            "تم جلب حالة البراند"
        ));
    }
}
