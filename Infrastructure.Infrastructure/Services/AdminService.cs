using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;
using ReelsCommerceSystem.Application.DTOs.Request.Admin;
using ReelsCommerceSystem.Application.DTOs.Response.Admin;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;


namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class AdminService : IAdminService
    {
        private readonly UserManager<User> _userManager;
        private readonly IJwtService _jwtService;

        public AdminService(
            UserManager<User> userManager,
            IJwtService jwtService)
        {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        public async Task<ApiResponse<AdminLoginResDto>> LoginAsync(AdminLoginReqDto dto)
        {
           
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user == null)
            {
                return ApiResponse<AdminLoginResDto>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Email not found",
                    "البريد الإلكتروني غير موجود"
                );
            }

           
            var isValidPassword = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (!isValidPassword)
            {
                return ApiResponse<AdminLoginResDto>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Incorrect password",
                    "كلمة المرور غير صحيحة"
                );
            }

           
            if (user.Role != Role.Admin)
            {
                return ApiResponse<AdminLoginResDto>.ErrorResponse(
                    HttpStatusCode.Forbidden,
                    "Access denied. Admins only",
                    "غير مسموح بالدخول - الأدمن فقط"
                );
            }

        
            var token = await _jwtService.CreateTokenAsync(user);

            var result = new AdminLoginResDto
            {
                Token = token
            };

            return ApiResponse<AdminLoginResDto>.SuccessResponse(
                result,
                HttpStatusCode.OK,
                "Login successful",
                "تم تسجيل الدخول بنجاح"
            );
        }
    }
}




