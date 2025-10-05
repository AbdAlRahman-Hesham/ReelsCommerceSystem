using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class AuthenticationService(UserManager<User> _userManager,IConfiguration _configuration) : IAuthenticationService
    {
   

        public async Task<LoginResDto> LoginAsync(LoginReqDto loginReqDto)
        {
            var User = await _userManager.FindByEmailAsync(loginReqDto.Email) ?? throw new UserNotFoundException(loginReqDto.Email);

            var IsPasswordValid = await _userManager.CheckPasswordAsync(User, loginReqDto.Password);
            if (IsPasswordValid)
            {
                return new LoginResDto
                {
                    Token =await CreateTokenAsync(User),
                    ExpiresAt = DateTime.UtcNow.AddHours(1)


                };
            }
            else throw new UnauthorizedException();


        }
        public async Task<RegisterResDto> RegisterAsync(RegisterReqDto registerReqDto)
        {
            var User = new User
            {
                DisplayName = registerReqDto.FirstName + " " + registerReqDto.LastName,
                Email=registerReqDto.Email,
                PhoneNumber=registerReqDto.PhoneNumber,
                UserName=registerReqDto.FirstName + registerReqDto.LastName,
            };
            var Result =await _userManager.CreateAsync(User, registerReqDto.Password);
            if (Result.Succeeded)
                return new RegisterResDto
                {
                 FirstName = registerReqDto.FirstName,
                 LastName = registerReqDto.LastName,
                  Email= User.Email,
                  PhoneNumber=User.PhoneNumber,
                  ProfileImagePath=null,
                  Token=await CreateTokenAsync(User)

                };

            else
            {
                var errors = Result.Errors.Select(e => new ValidationError
                {
                    Field = e.Code, 
                    En = e.Description,
                    Ar = "خطأ في الإدخال" 
                }).ToList();

                throw new BadRequestException(errors);
            }

    }
        private  async Task<string> CreateTokenAsync(User user)
        {
            var Claims = new List<Claim>()
            {
               new(ClaimTypes.Email,user.Email!),
               new(ClaimTypes.Name,user.UserName!),
               new(ClaimTypes.NameIdentifier,user.Id)
            };
            var Roles =await _userManager.GetRolesAsync(user);
            foreach(var role in Roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var SecretKey = _configuration.GetSection("JWTOptions")["SecretKey"];
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var Creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
            var Token = new JwtSecurityToken(
                issuer: _configuration["JWTOptions:Issuer"],
                audience: _configuration["JWTOptions:Audience"],
                claims:Claims,
                expires:DateTime.Now.AddHours(1),
                signingCredentials:Creds

                );
            return new JwtSecurityTokenHandler().WriteToken(Token);
        }

        public async Task<bool> CheckEmailAsync(string Email)
        {
            var User = await _userManager.FindByEmailAsync(Email);
            return User is not null;
        }
    }
}
