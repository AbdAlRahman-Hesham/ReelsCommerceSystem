using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
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
    [HttpGet("forYou")]
    [Authorize]
    public async Task<IActionResult> GetForYou()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsWithRecommendationSystemAsync(userId);

        var response = ApiResponse<List<ReelFeedRes>>.SuccessResponse(reels, System.Net.HttpStatusCode.OK);
        return Ok(response);
        
    }

    [HttpGet("following")]
    [Authorize]
    public async Task<IActionResult> GetFollowing()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var reels = await _reelFeedService.ReelsForUserFollowingAsync(userId);
        
        var response = ApiResponse<List<ReelFeedRes>>.SuccessResponse(reels, System.Net.HttpStatusCode.OK);

        return Ok(response);
        
    }

}
