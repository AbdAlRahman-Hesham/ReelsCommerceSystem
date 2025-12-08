using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    [Authorize]
    public class ReelCommentController : AppBaseController
    {
        private readonly IReelCommentService _reelCommentService;

        public ReelCommentController(IReelCommentService reelCommentService)
        {
            _reelCommentService = reelCommentService;
        }

        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment([FromBody] AddReelCommentReq dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                var errorResponse = ApiResponse<string>.ErrorResponse
                    (
                        HttpStatusCode.Unauthorized,
                        "User not authenticated",
                        "المستخدم غير مسجل دخول"
                    );

            }
            var response = await _reelCommentService.AddCommentAsync(dto, userId);
            return StatusCode(response.StatusCode, response);


        }
    }
}
