using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Identity;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class AuthenticationService(UserManager<User> _userManager, 
    IJwtService _jwtService, IOtpService _otpService, IUserImageService _userImageService,ITokenBlacklistService _tokenBlacklist) : IAuthenticationService
{


    public async Task<LoginResDto> LoginAsync(LoginReqDto loginReqDto)
    {
        var User = await _userManager.FindByEmailAsync(loginReqDto.Email) ?? throw new UserNotFoundException(loginReqDto.Email);

        if (!User.EmailConfirmed)
             throw new UnauthorizedException();

        var IsPasswordValid = await _userManager.CheckPasswordAsync(User, loginReqDto.Password);
        if (IsPasswordValid)
        {
            return new LoginResDto
            {
                Token =await _jwtService.CreateTokenAsync(User),
                ExpiresAt = DateTime.UtcNow.AddMonths(1)


            };
        }
        else throw new UnauthorizedException();


    }
    public async Task<RegisterResDto> RegisterAsync(RegisterReqDto registerReqDto)
    {
        if (await CheckEmailAsync(registerReqDto.Email))
        {
            var errors = new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "Email",
                    En = "Email is already in use.",
                    Ar = "البريد الإلكتروني مستخدم بالفعل."
                }
            };
            throw new BadRequestException(errors);
        }

        string? imagePath = null;
        if (registerReqDto.ProfileImage != null)
        {
            imagePath = await _userImageService.SaveUserImageAsync(registerReqDto.ProfileImage);
        }

        var user = new User
        {
            DisplayName = $"{registerReqDto.FirstName} {registerReqDto.LastName}",
            FirstName=registerReqDto.FirstName,
            LastName=registerReqDto.LastName,
            Gender=registerReqDto.Gender,
            DateOfBirth=registerReqDto.DateOfBirth,
            Email = registerReqDto.Email,
            PhoneNumber = registerReqDto.PhoneNumber,
            UserName = registerReqDto.Email,
            ImageURL = imagePath?? string.Empty,
            Role = Domain.Enums.Role.Customer
        };

        var result = await _userManager.CreateAsync(user, registerReqDto.Password);

        if (result.Succeeded)
        {
            await _otpService.SendOtpAsync(user.Email!);

            return new RegisterResDto();
        }
        else
        {
            var errors = result.Errors.Select(e => new ValidationError
            {
                Field = e.Code,
                En = e.Description,
                Ar = "خطأ في الإدخال"
            }).ToList();

            throw new BadRequestException(errors);
        }
    }
    public async Task<bool> CheckEmailAsync(string Email)
    {
        var User = await _userManager.FindByEmailAsync(Email);
        return User is not null;
    }

    public async Task SignOutAsync(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            throw new UnauthorizedException("Token is missing");

        token = token.StartsWith("Bearer ") ? token.Substring(7).Trim() : token.Trim();
        await _tokenBlacklist.AddAsync(token);
    }
}
