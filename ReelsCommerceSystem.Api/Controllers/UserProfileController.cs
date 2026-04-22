using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.UserProfile;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Exceptions;
using System.Security.Claims;
using System.Net;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Api.Controllers;

[Authorize]
public class UserProfileController : AppBaseController
{
    private readonly IUserProfileService _userProfileService;

    public UserProfileController(IUserProfileService userProfileService)
    {
        _userProfileService = userProfileService;
    }

    [HttpGet("ShippingAddress")]
    public async Task<IActionResult> GetShippingAddresses()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var addresses = await _userProfileService.GetShippingAddressesAsync(userId);
        return Ok(ApiResponse<object>.SuccessResponse(addresses, HttpStatusCode.OK, "Shipping addresses retrieved successfully."));
    }

    [HttpPost("ShippingAddress")]
    public async Task<IActionResult> AddShippingAddress([FromBody] ShippingAddressReqDto addressDto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var address = await _userProfileService.AddShippingAddressAsync(userId, addressDto);
        return Ok(ApiResponse<object>.SuccessResponse(address, HttpStatusCode.OK, "Shipping address added successfully."));
    }

    [HttpPatch("ShippingAddress/{id}")]
    public async Task<IActionResult> UpdateShippingAddress(int id, [FromBody] UpdateShippingAddressDto addressDto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        try
        {
            var address = await _userProfileService.UpdateShippingAddressAsync(userId, id, addressDto);
            return Ok(ApiResponse<object>.SuccessResponse(address, HttpStatusCode.OK, "Shipping address updated successfully."));
        }
        catch (System.Exception ex)
        {
            return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, ex.Message, "العنوان غير موجود أو لا يخص المستخدم."));
        }
    }

    [HttpDelete("ShippingAddress/{id}")]
    public async Task<IActionResult> DeleteShippingAddress(int id)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _userProfileService.DeleteShippingAddressAsync(userId, id);
        if (result)
            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Shipping address deleted successfully."));
        
        return NotFound(ApiResponse<object>.ErrorResponse(HttpStatusCode.NotFound, "Address not found or not owned by user.", "العنوان غير موجود أو لا يخص المستخدم."));
    }

    [HttpPut("UpdateProfile")]
    public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileReqDto profileDto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        try
        {
            var result = await _userProfileService.UpdateProfileAsync(userId, profileDto);
            
            string message = result.IsEmailChanged 
                ? "Profile updated. A verification code has been sent to your new email."
                : "Profile updated successfully.";
            
            string messageAr = result.IsEmailChanged
                ? "تم تحديث الملف الشخصي. تم إرسال رمز التحقق إلى بريدك الإلكتروني الجديد."
                : "تم تحديث الملف الشخصي بنجاح.";

            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, message, messageAr));
        }
        catch (BadRequestException ex)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to update profile.", "فشل في تحديث الملف الشخصي.", ex.Errors));
        }
        catch (System.Exception)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to update profile.", "فشل في تحديث الملف الشخصي."));
        }
    }

    [HttpPut("UpdatePassword")]
    public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordReqDto passwordDto)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _userProfileService.UpdatePasswordAsync(userId, passwordDto);
        if (result)
            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Password updated successfully."));

        return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to update password. Please check your current password.", "فشل في تحديث كلمة المرور. يرجى التأكد من كلمة المرور الحالية."));
    }

    [HttpPut("UpdateProfileImage")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateProfileImage(IFormFile image)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _userProfileService.UpdateProfileImageAsync(userId, image);
        if (result)
            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Profile image updated successfully."));

        return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to update profile image.", "فشل في تحديث صورة الملف الشخصي."));
    }

    [HttpDelete("DeleteAccount")]
    public async Task<IActionResult> DeleteAccount()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var result = await _userProfileService.DeleteAccountAsync(userId);
        if (result)
            return Ok(ApiResponse<object>.SuccessResponse(null, HttpStatusCode.OK, "Account deleted successfully."));

        return BadRequest(ApiResponse<object>.ErrorResponse(HttpStatusCode.BadRequest, "Failed to delete account.", "فشل في حذف الحساب."));
    }
}
