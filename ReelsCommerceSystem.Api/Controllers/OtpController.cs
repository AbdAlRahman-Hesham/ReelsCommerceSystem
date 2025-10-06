using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

public class OtpController:AppBaseController
{
    private readonly IOtpService _otpService;

    public OtpController(IOtpService otpService)
    {
        _otpService = otpService;
    }

    [HttpPost("ResendOtp")]
    public async Task<ActionResult<ApiResponse<string>>> ResendOtp([FromQuery] string email)
    {
        try
        {
            var success =  await _otpService.ResendOtp(email);

            var badresponse = ApiResponse<string>.SuccessResponse(
                "Please wait 1 minute before requesting a new OTP",
                HttpStatusCode.OK
            );
            if (!success)
                return Ok(badresponse);

            var response = ApiResponse<string>.SuccessResponse(
                "OTP resent successfully.",
                HttpStatusCode.OK
            );

            return Ok(response);
        }
        catch (InvalidOperationException ex)
        {
            var response = ApiResponse<string>.ErrorResponse(
                HttpStatusCode.BadRequest,
                ex.Message,
                "حدث خطأ أثناء إعادة إرسال رمز التحقق."
            );
            return BadRequest(response);
        }
        catch (Exception)
        {
            var response = ApiResponse<string>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "An unexpected error occurred.",
                "حدث خطأ غير متوقع."

            );
            return StatusCode(500, response);
        }
    }


    [HttpPost("VerifyOtp")]
    public async Task<ActionResult<ApiResponse<string>>> VerifyOtp([FromBody] VerifyOtpRequest model)
    {
        var isValid = await _otpService.ValidateOtp(model.Email, model.Otp);

        if (!isValid)
        {
            var response = ApiResponse<string>.ErrorResponse(
                HttpStatusCode.BadRequest,
                "Invalid or expired OTP.",
                "رمز التحقق غير صالح أو منتهي الصلاحية."
            );
            return BadRequest(response);
        }

        var successResponse = ApiResponse<string>.SuccessResponse(
            "OTP verified successfully.",
            HttpStatusCode.OK
        );

        return Ok(successResponse);
    }
}

public class VerifyOtpRequest
{
    public string Email { get; set; } = string.Empty;
    public string Otp { get; set; } = string.Empty;
}


