using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.UserInfo;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _context;

        public UserInfoService(UserManager<User> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public  async Task<UserInfoResDto> GetUserInfoAsync(string userId)
        {
            var User = await _context.Users
                .Include(u => u.BrandFollows)
                .Include(u => u.Orders)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (User == null) throw new UserNotFoundException(userId);
            var roles = await _userManager.GetRolesAsync(User);
            return new UserInfoResDto
            {
                Role= roles.FirstOrDefault() ?? SystemRoles.User,
                FirstName = User.FirstName ?? string.Empty,
                LastName= User.LastName ?? string.Empty,
                Email =User.Email ?? string.Empty,
                PhoneNumber = User.PhoneNumber ?? string.Empty,
                Gender = User.Gender,
               DateOfBirth = User.DateOfBirth ?? DateTime.MinValue,
               ProfileImageUrl = User.ImageURL ?? string.Empty,
               NumberOfFollowing = User.BrandFollows?.Count ?? 0,
               NumberOfOrders = User.Orders?.Count ?? 0,
            };

        }
    }
}
