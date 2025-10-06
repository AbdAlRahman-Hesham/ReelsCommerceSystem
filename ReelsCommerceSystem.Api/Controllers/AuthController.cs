using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using MyAuthService = ReelsCommerceSystem.Application.Interfaces.Services.IAuthenticationService;



namespace ReelsCommerceSystem.Api.Controllers;

public class AuthController(MyAuthService _authenticationService) : AppBaseController
{
   

    [HttpPost("Login")]
    public async Task<ActionResult<ApiResponse<LoginResDto>>> Login([FromBody] LoginReqDto loginReq)
    {
        try
        {
            var result = await _authenticationService.LoginAsync(loginReq);

            var response = ApiResponse<LoginResDto>.SuccessResponse(
                result,
                HttpStatusCode.OK,
                "Login successful.",
                "تم تسجيل الدخول بنجاح."
            );

            return Ok(response);
        }
        catch (UserNotFoundException ex)
        {
            var response = ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.NotFound,
                ex.Message,
                "المستخدم غير موجود."
            );
            return NotFound(response);
        }
        catch (UnauthorizedException)
        {
            var response = ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.Unauthorized,
                "Invalid credentials.",
                "بيانات تسجيل الدخول غير صحيحة."
            );
            return Unauthorized(response);
        }
        catch (Exception ex)
        {
            var response = ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                ex.Message,
                "حدث خطأ غير متوقع."
            );
            return StatusCode((int)HttpStatusCode.InternalServerError, response);
        }
    }

    [HttpPost("Register")]
    public async Task<ActionResult<ApiResponse<RegisterResDto>>> Register([FromForm] RegisterReqDto registerReqDto)
    {
        try
        {
            var user = await _authenticationService.RegisterAsync(registerReqDto);

            var response = ApiResponse<RegisterResDto>.SuccessResponse(
                user,
                HttpStatusCode.OK,
                "User registered successfully.",
                "تم تسجيل المستخدم بنجاح."
            );

            return Ok(response);
        }
        catch (BadRequestException ex)
        {
            var response = ApiResponse<RegisterResDto>.ErrorResponse(
                HttpStatusCode.BadRequest,
                "Invalid input data.",
                "خطأ في البيانات المدخلة.",
                ex.Errors
            );
            return BadRequest(response);
        }
        catch (Exception ex)
        {
            var response = ApiResponse<RegisterResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                ex.Message,
                "حدث خطأ غير متوقع."
            );
            return StatusCode((int)HttpStatusCode.InternalServerError, response);
        }
    }

    [HttpGet("CheckEmail")]
    public async Task<ActionResult<ApiResponse<bool>>> CheckEmail([FromQuery] string Email)
    {
        var result = await _authenticationService.CheckEmailAsync(Email);
        var response = ApiResponse<bool>.SuccessResponse(result, HttpStatusCode.OK);
        return Ok(response);
    }

}