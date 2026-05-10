using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class JwtService(UserManager<User> _userManager, IConfiguration _configuration) : IJwtService
{
     
    public async Task<string> CreateTokenAsync(User user)
    {
        var Claims = new List<Claim>()
        {
           new(ClaimTypes.Email,user.Email!),
           new(ClaimTypes.Name,user.UserName!),
           new(ClaimTypes.NameIdentifier,user.Id),
        };
        var Roles = await _userManager.GetRolesAsync(user);
        foreach (var role in Roles)
        {
            Claims.Add(new Claim(ClaimTypes.Role, role));
        }
        var SecretKey = _configuration.GetSection("JWTOptions")["SecretKey"];
        var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey!));
        var Creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
        var Token = new JwtSecurityToken(
            issuer: _configuration["JWTOptions:Issuer"],
            audience: _configuration["JWTOptions:Audience"],
            claims: Claims,
            expires: DateTime.Now.AddMonths(1),
            signingCredentials: Creds

            );
        return new JwtSecurityTokenHandler().WriteToken(Token);
    }
}