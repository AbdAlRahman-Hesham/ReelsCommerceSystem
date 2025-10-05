using System.Net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Responses;
using MyAuthService = ReelsCommerceSystem.Application.Interfaces.Services.IAuthenticationService;



namespace ReelsCommerceSystem.Api.Controllers;

public class AuthController:AppBaseController
{
    private readonly MyAuthService _authenticationService;

    public AuthController(MyAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("Login")]
    public async Task<ActionResult<LoginResDto>> Login([FromBody] LoginReqDto loginReq)
    {
        var User = await _authenticationService.LoginAsync(loginReq);
        var response = ApiResponse<LoginResDto>.SuccessResponse(User, HttpStatusCode.OK);
        return Ok(response);
    }
    [HttpPost("Register")]
    public async Task<ActionResult<RegisterResDto>> Register([FromBody] RegisterReqDto registerReqDto)
    {
        var User = await _authenticationService.RegisterAsync(registerReqDto);
        var response = ApiResponse<RegisterResDto>.SuccessResponse(User, HttpStatusCode.OK);
        return Ok(response);
    }

    [HttpGet("CheckEmail")]
    public async Task<ActionResult<bool>> CheckEmail(string Email)
    {
        var Result = await _authenticationService.CheckEmailAsync(Email);
        var response = ApiResponse<bool>.SuccessResponse(Result, HttpStatusCode.OK);
        return Ok(response);
    }
}