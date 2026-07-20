using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class BrandVerificationController(IBrandVerificationService _brandVerificationService) : AppBaseController
    {
        [Authorize]
        [HttpPost("verify")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> VerifyBrand([FromForm] VerifyBrandReq request)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var result = await _brandVerificationService.VerifyBrandAsync(userId, request);

            return StatusCode(result.StatusCode, result);
        }
    }
}
