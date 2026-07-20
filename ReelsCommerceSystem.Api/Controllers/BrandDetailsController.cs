using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

[Authorize]
public class BrandDetailsController(IBrandDetailsService _brandDetailsService) : AppBaseController
{
    [HttpGet("{brandId}")]
    public async Task<IActionResult> GetBrandDetails(int brandId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var result = await _brandDetailsService.GetBrandDetailsAsync(brandId, userId);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPut("{brandId}")]
    public async Task<IActionResult> UpdateBrandDetails(int brandId, [FromBody] UpdateBrandDetailsReq dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized(
                ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Unauthorized.",
                    "غير مصرح."));
        }

        var result = await _brandDetailsService.UpdateBrandDetailsAsync(brandId, userId, dto);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet("{brandId}/top-engaged-users")]
    public async Task<IActionResult> GetTopEngagedUsers(int brandId, [FromQuery] int count = 10)
    {
        var result = await _brandDetailsService.GetTopEngagedUsersAsync(brandId, count);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost("{brandId}/logo")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadLogo(int brandId, IFormFile file)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized, "Unauthorized.", "غير مصرح."));

        var result = await _brandDetailsService.UploadLogoAsync(brandId, userId, file);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost("{brandId}/cover")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadCover(int brandId, IFormFile file)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized, "Unauthorized.", "غير مصرح."));

        var result = await _brandDetailsService.UploadCoverAsync(brandId, userId, file);
        return StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{brandId}/logo")]
    public async Task<IActionResult> DeleteLogo(int brandId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized, "Unauthorized.", "غير مصرح."));

        var result = await _brandDetailsService.DeleteLogoAsync(brandId, userId);
        return StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{brandId}/cover")]
    public async Task<IActionResult> DeleteCover(int brandId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized, "Unauthorized.", "غير مصرح."));

        var result = await _brandDetailsService.DeleteCoverAsync(brandId, userId);
        return StatusCode(result.StatusCode, result);
    }
}
