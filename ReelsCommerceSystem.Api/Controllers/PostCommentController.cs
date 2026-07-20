using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Api.Controllers;
using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Responses;
using System.Security.Claims;

namespace ReelsCommerceSystem.APIs.Controllers;

public class PostCommentController(IPostCommentService _postCommentService): AppBaseController
{
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateComment( [FromBody] CreatePostCommentReq req)
    {
        var userId =User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        var result = await _postCommentService.CreateCommentAsync(req, userId);

        return Ok(ApiResponse<int>.SuccessResponse(
            result,
            System.Net.HttpStatusCode.OK));
    }

    [Authorize]
    [HttpGet("Post/{postId}")]
    public async Task<IActionResult> GetPostComments([FromRoute] int postId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        var result = await _postCommentService
            .GetPostCommentsAsync(postId, userId);

        return Ok(ApiResponse<IEnumerable<PostCommentRes>>
            .SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
    }

    [Authorize]
    [HttpGet("{commentId}")]
    public async Task<IActionResult> GetComment(
        [FromRoute] int commentId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        var result = await _postCommentService
            .GetCommentByIdAsync(commentId, userId);

        return Ok(ApiResponse<PostCommentRes>
            .SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
    }

    [Authorize]
    [HttpPatch]
    public async Task<IActionResult> UpdateComment([FromBody] UpdatePostCommentReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        await _postCommentService.UpdateCommentAsync(req, userId);

        return Ok(ApiResponse<bool>.SuccessResponse(
            true,
            System.Net.HttpStatusCode.OK));
    }

    [Authorize]
    [HttpDelete("{commentId}")]
    public async Task<IActionResult> DeleteComment(
        [FromRoute] int commentId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        await _postCommentService
            .DeleteCommentAsync(commentId, userId);

        return Ok(ApiResponse<bool>.SuccessResponse(
            true,
            System.Net.HttpStatusCode.OK));
    }

    [Authorize]
    [HttpGet("{commentId}/Like")]
    public async Task<IActionResult> ToggleCommentLike([FromRoute] int commentId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null)
            return Unauthorized();

        var result = await _postCommentService
            .ToggleCommentLikeAsync(commentId, userId);

        return Ok(ApiResponse<ToggleCommentLikeRes>
            .SuccessResponse(
                result,
                System.Net.HttpStatusCode.OK));
    }
}
