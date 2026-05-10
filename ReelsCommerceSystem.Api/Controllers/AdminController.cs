using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Admin;
using ReelsCommerceSystem.Application.DTOs.Response.Admin;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Api.Controllers
{

    [Route("api/admin")]
    [ApiController]
    public class AdminController : AppBaseController
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

       
        [HttpPost("login")]
       
        public async Task<ActionResult<ApiResponse<AdminLoginResDto>>> Login([FromBody] AdminLoginReqDto dto)
        {
            var result = await _adminService.LoginAsync(dto);
            return StatusCode(result.StatusCode, result);
        }
    }
}
