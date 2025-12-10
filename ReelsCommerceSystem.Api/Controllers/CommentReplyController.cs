using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Request.Reply;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    [Authorize]
    public class CommentReplyController : AppBaseController
    {
        private readonly IReplyService _replyService;

        public CommentReplyController(IReplyService replyService)
        {
            _replyService = replyService;
            
        }

        [HttpGet("{commentId}")]
        public async Task<IActionResult> GetCommentReplies(
        int commentId,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10)
        {

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var response = await _replyService.GetRepliesAsync(
               commentId,
               pageNumber,
               pageSize,
               userId);

            return StatusCode(response.StatusCode, response);
        }
        [HttpPost("reply")]

        public async Task<IActionResult> AddReply([FromBody] AddReplyReq dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Unauthorized",
                    "غير مصرح"
                ));

            var result = await _replyService.AddRepliesAsync(dto, userId);

            return StatusCode((int)result.StatusCode, result);
        }

        [HttpPost("toggle-reply-like")]
        public async Task<IActionResult> ToggleReplyLike([FromBody] Application.DTOs.Request.Reply.ToggleRepyLikeReq dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized(ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Unauthorized",
                    "غير مصرح لك"
                ));
            }

            var response = await _replyService.ToggleReplyLikeAsync(dto.ReplyId, userId);

            return StatusCode(response.StatusCode, response);
        }

    }
}
