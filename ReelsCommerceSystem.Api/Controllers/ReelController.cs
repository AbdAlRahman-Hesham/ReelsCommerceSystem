using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;
using ReelsCommerceSystem.Shared.Responses;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

public class ReelController(IReelService _reelService,IReelFeedService _reelFeedService) :AppBaseController
{
    [HttpGet("{brandId}")]
    public async Task<IActionResult> GetReelsByBrand(int brandId, [FromQuery] string? sortBy = null)
    {
        var response = await _reelService.GetReelsByBrandAsync(brandId, sortBy);
        return StatusCode(response.StatusCode, response);
    }
    [Authorize]
    [HttpPost("toggle-like/{reelId}")]
    public async Task<IActionResult> ToggleLike(int reelId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        if (userId == null)
            return Unauthorized("User not authenticated");

        var result = await _reelService.ToggleReelLikeAsync(userId,reelId);
        var messageEn = result
                ? "Like added successfully."
                : "Like removed successfully.";

        var messageAr = result
            ? "تم إضافة الإعجاب بنجاح."
            : "تم إزالة الإعجاب بنجاح.";

        var response = ApiResponse<bool>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            messageEn,
            messageAr);
        return Ok(response);
    }
    [HttpGet("forYou")]
    [Authorize]
    public async Task<IActionResult> GetForYou([FromQuery] int pageIndex=1, int pageSize=10)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsWithRecommendationSystemAsync(userId,pageIndex,pageSize);

        var response = ApiResponse<List<ReelFeedRes>>.SuccessResponse(reels, System.Net.HttpStatusCode.OK);
        return Ok(response);
        
    }

    [HttpGet("following")]
    [Authorize]
    public async Task<IActionResult> GetFollowing([FromQuery] int pageIndex=1, int pageSize=10)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsForUserFollowingAsync(userId,pageIndex,pageSize);
        
        var response = ApiResponse<List<ReelFeedRes>>.SuccessResponse(reels, System.Net.HttpStatusCode.OK);

        return Ok(response);
        
    }

}
