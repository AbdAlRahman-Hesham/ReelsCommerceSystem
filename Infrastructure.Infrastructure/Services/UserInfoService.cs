using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.UserInfo;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Exceptions;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly UserManager<User> _userManager;

        public UserInfoService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public  async Task<UserInfoResDto> GetUserInfoAsync(string userId)
        {
            var User = await _userManager.FindByIdAsync(userId);
            if (User == null) throw new UserNotFoundException(userId);
            var roles = await _userManager.GetRolesAsync(User);
            return new UserInfoResDto
            {
                Role= roles.FirstOrDefault() ?? "User",
                FirstName = User.FirstName ?? string.Empty,
                LastName= User.LastName ?? string.Empty,
                Email =User.Email ?? string.Empty,
                PhoneNumber = User.PhoneNumber ?? string.Empty,
                Gender = User.Gender,
               DateOfBirth = User.DateOfBirth ?? DateTime.MinValue,
               ProfileImageUrl = User.ImageURL ?? string.Empty,
            };
          
        }
    }
}
