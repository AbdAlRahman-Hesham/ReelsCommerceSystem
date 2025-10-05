using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Application.Interfaces.Services;
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
        return Ok(User);
    }
    [HttpPost("Register")]
    public async Task<ActionResult<RegisterResDto>> Register([FromBody] RegisterReqDto registerReqDto)
    {
        var User = await _authenticationService.RegisterAsync(registerReqDto);
        return Ok(User);
    }

    [HttpGet("CheckEmail")]
    public async Task<ActionResult<bool>> CheckEmail(string Email)
    {
        var Result = await _authenticationService.CheckEmailAsync(Email);
        return Ok(Result);
    }
}