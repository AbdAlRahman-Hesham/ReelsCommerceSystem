using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.UserInfo;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IUserInfoService
    {
        Task<UserInfoResDto> GetUserInfoAsync(string userId);
    }
}
