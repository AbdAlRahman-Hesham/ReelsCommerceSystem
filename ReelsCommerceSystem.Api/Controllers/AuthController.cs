using System;
using System.Net;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.UserInfo;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using MyAuthService = ReelsCommerceSystem.Application.Interfaces.Services.IAuthenticationService;



namespace ReelsCommerceSystem.Api.Controllers;

public class AuthController : AppBaseController
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserInfoService _userInfoService;

    public AuthController(IAuthenticationService authenticationService, IUserInfoService userInfoService)
    {
        _authenticationService = authenticationService;
        _userInfoService = userInfoService;
    }





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
    public async Task<ActionResult<ApiResponse<RegisterResDto>>> Register([FromBody] RegisterReqDto registerReqDto)
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


    
    [HttpPost("SignOut")]
    public async Task<ActionResult<ApiResponse<SignOutRes>>> SignOut()
    {
        try
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrWhiteSpace(token))
            {
                var response = ApiResponse<SignOutRes>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Authorization token is missing.",
                    "رمز الجلسة مفقود."
                );
                return BadRequest(response);
            }
    [Authorize]
    [HttpGet("UserInfo")]
   
    public async Task<ActionResult<ApiResponse<UserInfoResDto>>> GetUserInfo()
    {
        try
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(ApiResponse<UserInfoResDto>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Token is missing or invalid.",
                    "التوكن مفقود أو غير صالح."
                ));
            }

            var userInfo = await _userInfoService.GetUserInfoAsync(userId);
            return Ok(ApiResponse<UserInfoResDto>.SuccessResponse(userInfo, HttpStatusCode.OK));
        }
        catch (UserNotFoundException)
        {
            return NotFound(ApiResponse<UserInfoResDto>.ErrorResponse(
                HttpStatusCode.NotFound,
                "User not found.",
                "المستخدم غير موجود."
            ));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<UserInfoResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                ex.Message,
                "حدث خطأ في السيرفر."
            ));
        }
    }

          
            token = token.Replace("Bearer ", "").Trim();

            await _tokenBlacklist.AddAsync(token);

         
            await _authenticationService.SignOutAsync(token);

            var responseSuccess = ApiResponse<SignOutRes>.SuccessResponse(
                new SignOutRes(),
                HttpStatusCode.OK,
                "Signed out successfully.",
                "تم تسجيل الخروج بنجاح."
            );

            return Ok(responseSuccess);
        }
        catch (UnauthorizedException ex)
        {
            var response = ApiResponse<SignOutRes>.ErrorResponse(
                HttpStatusCode.Unauthorized,
                ex.Message,
                "صلاحية الجلسة غير صالحة."
            );
            return Unauthorized(response);
        }
        catch (Exception ex)
        {
            var response = ApiResponse<SignOutRes>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                ex.Message,
                "حدث خطأ أثناء تسجيل الخروج."
            );
            return StatusCode((int)HttpStatusCode.InternalServerError, response);
        }
    }



}