using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IAuthenticationService
    {
        
        Task<LoginResDto> LoginAsync(LoginReqDto loginReqDto);
        
        Task<RegisterResDto> RegisterAsync(RegisterReqDto registerReqDto);
        Task<bool> CheckEmailAsync(string Email);

    }
}
