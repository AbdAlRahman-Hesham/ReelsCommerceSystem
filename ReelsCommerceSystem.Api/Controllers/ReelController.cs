using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Reel;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

public class ReelController(
    IReelService _reelService,
    IReelFeedService _reelFeedService,
    IReelAnalyticsService _reelAnalyticsService
) : AppBaseController
{
    [HttpGet("{brandId}")]
    public async Task<IActionResult> GetReelsByBrand(int brandId, [FromQuery] string? sortBy = null)
    {
        var response = await _reelService.GetReelsByBrandAsync(brandId, sortBy);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("topbrands")]
    public async Task<IActionResult> GetTopBrands([FromQuery] int topN = 5)
    {
        if (topN <= 0)
            return BadRequest(new { message = "The number of top brands must be greater than zero." });

        var topBrands = await _reelAnalyticsService.GetTopBrandsLastWeekAsync(topN);

        return Ok(new
        {
            topN,
            brands = topBrands
        });
    }

    [Authorize]
    [HttpPost("toggle-like/{reelId}")]
    public async Task<IActionResult> ToggleLike(int reelId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        if (string.IsNullOrEmpty(userId))
            return Unauthorized("User not authenticated");

        var response = await _reelService.ToggleReelLikeAsync(userId, reelId);

        return StatusCode(response.StatusCode, response);
    }

    [Authorize]
    [HttpGet("forYou")]
    public async Task<IActionResult> GetForYou([FromQuery] int pageIndex = 1, int pageSize = 10)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsWithRecommendationSystemAsync(userId, pageIndex, pageSize);

        var response = ApiResponse<PaginationResponse<ReelFeedRes>>.SuccessResponse(
            reels,
            HttpStatusCode.OK,
            "Reels loaded successfully.",
            "تم تحميل المقاطع بنجاح."
        );

        return Ok(response);
    }

    [Authorize]
    [HttpGet("following")]
    public async Task<IActionResult> GetFollowing([FromQuery] int pageIndex = 1, int pageSize = 10)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsForUserFollowingAsync(userId, pageIndex, pageSize);

        var response = ApiResponse<PaginationResponse<ReelFeedRes>>.SuccessResponse(
            reels,
            HttpStatusCode.OK,
            "Reels loaded successfully.",
            "تم تحميل المقاطع بنجاح."
        );

        return Ok(response);
    }

    [Authorize]
    [HttpPost("TrackReelView")]
    public async Task<IActionResult> TrackReelView([FromBody] ReelViewReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var result = await _reelService.TrackReelViewAsync(userId, req);

        return StatusCode(result.StatusCode, result);
    }
}

