using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Interest;
using ReelsCommerceSystem.Application.DTOs.Response.Interest;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class InterestController:AppBaseController
    {
        private readonly IInterestService _interest;

        public InterestController(IInterestService interest)
        {
            _interest = interest;
        }
        [HttpGet("Interests")]
        public async Task<ActionResult<ApiResponse<List<UserInterestResDto>>>> GetAllInterests()
        {
            try
            {
                var interests = await _interest.GetAllInterestsAsync();
                return Ok(ApiResponse<List<UserInterestResDto>>.SuccessResponse(
                    interests,
                    HttpStatusCode.OK,
                    en: "Interests retrieved successfully.",
                    ar:"تم جلب الاهتمامات بنجاح."

                    ));
            }
            catch (Exception)
            {
                return StatusCode(500, ApiResponse<List<UserInterestResDto>>.ErrorResponse(HttpStatusCode.InternalServerError,
                    en: "An error occured while retrieving interests.",
                    ar: "حدث خطأ أثناء جلب الاهتمامات."));
            }

        }
        [Authorize]
        [HttpPost("UserInterests")]
        public async Task<IActionResult> SaveUserInterests([FromBody] UserInterestSaveRequestDto request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var response = await _interest.SaveUserInterestsAsync(userId, request);
            return StatusCode(response.StatusCode, response);
        }

    }
}
