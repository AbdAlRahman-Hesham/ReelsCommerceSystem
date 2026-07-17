using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class CommunityController(ICommunityService _communityService) :AppBaseController
    {
        [Authorize]
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreatePost([FromForm] CreatePostReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.CreatePostAsync(req, userId);
            return Ok(ApiResponse<CreatePostRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK
            ));
        }

        [Authorize]
        [HttpGet("{postId}")]
        public async Task<IActionResult> GetPost([FromRoute] int postId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();
            var result = await _communityService.GetPostAsync(postId, userId);

            return Ok(ApiResponse<GetPostRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
        }

        [Authorize]
        [HttpGet("Posts")]
        public async Task<IActionResult> GetPosts([FromQuery]GetCommunityPostsReq req)
        {
            var userId=User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.GetPostsAsync(req, userId);
            return Ok(ApiResponse<GetCommunityPostsRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));


        }

        [Authorize]
        [HttpPatch]
        public async Task<IActionResult> EditPost([FromQuery] EditPostReq req)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.EditPostAsync(req, userId);
            return Ok(ApiResponse<EditPostRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
        }

        [Authorize]
        [HttpPatch("Status")]
        public async Task<IActionResult> UpdatePostStatus([FromQuery] int postId, [FromQuery] string status)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.UpdatePostStatusAsync(postId, status, userId);
            return Ok(ApiResponse<EditPostRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
        }

        [Authorize]
        [HttpDelete("{postId}")]
        public async Task<IActionResult> Delete([FromRoute] int postId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.DeletePostAsync(postId, userId);
            return Ok(ApiResponse<bool>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
        }

        [Authorize]
        [HttpGet("{postId}/PostLike")]
        public async Task<IActionResult> PostLikeToggle([FromRoute] int postId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return Unauthorized();

            var result = await _communityService.TogglePostLikeAsync(postId,userId);
            return Ok(ApiResponse<TogglePostLikeRes>.SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
        }

    }
}
