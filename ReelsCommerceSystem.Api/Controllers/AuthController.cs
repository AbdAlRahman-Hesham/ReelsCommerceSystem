using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.UserInfo;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Api.Controllers;

public class AuthController : AppBaseController
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserInfoService _userInfoService;
    private readonly ITokenBlacklistService _tokenBlacklist;
    private readonly UserManager<User> _userManager;
    private readonly IOtpService _otpService;

    public AuthController(
        IAuthenticationService authenticationService,
        IUserInfoService userInfoService,
        ITokenBlacklistService tokenBlacklistService,
        UserManager<User> userManager,
        IOtpService otpService)
        
    {
        _authenticationService = authenticationService;
        _userInfoService = userInfoService;
        _tokenBlacklist = tokenBlacklistService;
        _userManager = userManager;
        _otpService = otpService;
    }

    [HttpPost("Login")]
    public async Task<ActionResult<ApiResponse<LoginResDto>>> Login([FromBody] LoginReqDto loginReq)
    {
        try
        {
            var result = await _authenticationService.LoginAsync(loginReq);

            return Ok(ApiResponse<LoginResDto>.SuccessResponse(
                result,
                HttpStatusCode.OK,
                "Welcome back!",
                "أهلاً بعودتك!"
            ));
        }
        catch (UserNotFoundException)
        {
            return NotFound(ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.NotFound,
                "We couldn’t find an account with these details.",
                "لم يتم العثور على حساب بهذه البيانات."
            ));
        }
        catch (UnauthorizedException)
        {
            return Unauthorized(ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.Unauthorized,
                "The email or password you entered is incorrect.",
                "البريد الإلكتروني أو كلمة المرور غير صحيحة."
            ));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<LoginResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "Something went wrong. Please try again later.",
                "حدث خطأ ما، برجاء المحاولة لاحقًا."
            ));
        }
    }

    [HttpPost("Register")]
    public async Task<ActionResult<ApiResponse<RegisterResDto>>> Register([FromForm] RegisterReqDto registerReqDto)
    {
        try
        {
            var user = await _authenticationService.RegisterAsync(registerReqDto);

            return Ok(ApiResponse<RegisterResDto>.SuccessResponse(
                user,
                HttpStatusCode.OK,
                "Your account has been created successfully.",
                "تم إنشاء حسابك بنجاح."
            ));
        }
        catch (BadRequestException ex)
        {
            return BadRequest(ApiResponse<RegisterResDto>.ErrorResponse(
                HttpStatusCode.BadRequest,
                "Please check your information and try again.",
                "يرجى مراجعة بياناتك والمحاولة مرة أخرى.",
                ex.Errors
            ));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<RegisterResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "We couldn’t complete your registration right now. Please try again later.",
                "لم نتمكن من إتمام عملية التسجيل الآن، برجاء المحاولة لاحقًا."
            ));
        }
    }

    [HttpGet("CheckEmail")]
    public async Task<ActionResult<ApiResponse<bool>>> CheckEmail([FromQuery] string Email)
    {
        var result = await _authenticationService.CheckEmailAsync(Email);
        var message = result
            ? "This email is already registered."
            : "This email is available.";
        var messageAr = result
            ? "هذا البريد الإلكتروني مسجل بالفعل."
            : "البريد الإلكتروني متاح.";

        return Ok(ApiResponse<bool>.SuccessResponse(result, HttpStatusCode.OK, message, messageAr));
    }

    [HttpPost("SignOut")]
    public async Task<ActionResult<ApiResponse<SignOutRes>>> SignOut()
    {
        try
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest(ApiResponse<SignOutRes>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "You need to be signed in first.",
                    "يجب تسجيل الدخول أولاً."
                ));
            }

            token = token.Replace("Bearer ", "").Trim();

            await _tokenBlacklist.AddAsync(token);
            await _authenticationService.SignOutAsync(token);

            return Ok(ApiResponse<SignOutRes>.SuccessResponse(
                new SignOutRes(),
                HttpStatusCode.OK,
                "You’ve been signed out successfully.",
                "تم تسجيل خروجك بنجاح."
            ));
        }
        catch (UnauthorizedException)
        {
            return Unauthorized(ApiResponse<SignOutRes>.ErrorResponse(
                HttpStatusCode.Unauthorized,
                "Your session has already expired. Please log in again.",
                "انتهت صلاحية الجلسة. يرجى تسجيل الدخول مرة أخرى."
            ));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<SignOutRes>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "Something went wrong while signing out. Please try again later.",
                "حدث خطأ أثناء تسجيل الخروج، برجاء المحاولة لاحقًا."
            ));
        }
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
                    "Your session is no longer valid. Please sign in again.",
                    "انتهت صلاحية الجلسة، يرجى تسجيل الدخول مرة أخرى."
                ));
            }

            var userInfo = await _userInfoService.GetUserInfoAsync(userId);
            return Ok(ApiResponse<UserInfoResDto>.SuccessResponse(
                userInfo,
                HttpStatusCode.OK,
                "Here’s your account information.",
                "إليك معلومات حسابك."
            ));
        }
        catch (UserNotFoundException)
        {
            return NotFound(ApiResponse<UserInfoResDto>.ErrorResponse(
                HttpStatusCode.NotFound,
                "We couldn’t find your account.",
                "لم نتمكن من العثور على حسابك."
            ));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<UserInfoResDto>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "Something went wrong while fetching your details.",
                "حدث خطأ أثناء جلب بياناتك."
            ));
        }
    }

    [Authorize]
    [HttpPost("ResetPassword")]
    public async Task<ActionResult<ApiResponse<string>>> ResetPassword([FromBody] ResetPasswordReqDto resetPassword)
    {
        try
        {
            if(resetPassword is null || string.IsNullOrWhiteSpace(resetPassword.NewPassword))
            {
                return BadRequest(ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest,
                    "New password is required.",
                    "كلمة المرور الجديدة مطلوب."));
            }
            var token = HttpContext.Request.Headers["Authorization"].ToString()?.Replace("Bearer ", "");
            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized,
                    "Missing Token",
                    "التوكن مفقود"));
            }
            var checkToken = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken;
            try
            {
                jwtToken = checkToken.ReadJwtToken(token);
            }
            catch
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized,
                    "Invalid Token.",
                    "التوكن غير صالح."));
            }
            if (jwtToken.ValidTo < DateTime.UtcNow)
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized,
                    "Expiration date has passed.",
                     "تاريخ انتهاء الصلاحية قد مضى."));
            }
            var email = jwtToken.Claims.FirstOrDefault(j => j.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized,
                        "Token does not contain user email.",
                "التوكن لا يحتوي على البريد الإلكتروني للمستخدم."));
            }
            var user = await _userManager.FindByEmailAsync(email);
            if(user is null)
            {
                return NotFound(ApiResponse<string>.ErrorResponse(HttpStatusCode.NotFound,
                    "User not found.",
                    "المستخدم غير موجود.")); 
            }
            var removepassword = await _userManager.RemovePasswordAsync(user);
            if (!removepassword.Succeeded)
            {
                return BadRequest(ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest,
                    "Failed to remove old password.",
                     "فشل في إزالة كلمة المرور القديمة."
                    ));
            }
            var addpassword = await _userManager.AddPasswordAsync(user, resetPassword.NewPassword);
            if (!addpassword.Succeeded)
            {
                var errors = addpassword.Errors.Select(e => new ValidationError
                {
                    Field = "Password",
                    En = e.Description,
                    Ar = "خطأ في كلمة المرور الجديدة."
                }).ToList();
                return BadRequest(ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest,
                    "Failed to set new password.",
                    "فشل في تعيين كلمه المرور الجديدة."));
            }
            return Ok(ApiResponse<string>.SuccessResponse(
                null,
                HttpStatusCode.OK,
                "Password has been reset successfully.",
                 "تم إعادة تعيين كلمة المرور بنجاح."));

        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<string>.ErrorResponse(
                HttpStatusCode.InternalServerError,
                "An error occurred while resetting the password.",
                "حدث خطأ أثناء إعادة تعيين كلمة المرور."
            ));
        }
    }
}
