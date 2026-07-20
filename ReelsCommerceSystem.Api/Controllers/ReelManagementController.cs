using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class ReelManagementController(IReelManagementService _service) : AppBaseController
    {
        [Authorize]
        [HttpGet("Reels")]
        public async Task<IActionResult> GetReels([FromQuery] GetBrandReelsReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.GetBrandReelsAsync(req, userId);

            return Ok(ApiResponse<GetBrandReelsRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));
        }

        [Authorize]
        [HttpGet("Products")]
        public async Task<IActionResult> GetProducts([FromQuery] GetProductsForBrandReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.GetProductsForBrandAsync(req, userId);

            return Ok(ApiResponse<GetProductsForBrandRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));
        }

        [Authorize]
        [HttpPost]
        [Consumes("multipart/form-data")]

        public async Task<IActionResult> CreateReel([FromForm] CreateReelReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.CreateReelAsync(req, userId);
            return Ok(ApiResponse<CreateReelRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));

        }

        [Authorize]
        [HttpPatch]
        [Consumes("multipart/form-data")]

        public async Task<IActionResult> UpdateReel([FromForm] EditReelReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.EditReelAsync(req, userId);
            return Ok(ApiResponse<EditReelRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));

        }

        [Authorize]
        [HttpGet("{reelId}")]
        public async Task<IActionResult> GetReel(int reelId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.GetReelAsync(reelId,userId);

            return Ok(ApiResponse<GetReelForManagementRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));


        }

        [Authorize]
        [HttpGet("Analytics")]
        public async Task<IActionResult> GetReelAnalytics(int reelId,int year)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.GetReelAnalyticsAsync(reelId,year,userId);

            return Ok(ApiResponse<GetReelAnalyticsRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete(int reelId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _service.DeleteReelAsync(reelId,userId);

            return Ok(ApiResponse<bool>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));
        }



    }
}
