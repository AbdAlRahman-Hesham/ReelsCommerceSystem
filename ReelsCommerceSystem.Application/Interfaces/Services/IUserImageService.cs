using Microsoft.AspNetCore.Http;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IUserImageService
{
    Task<string?> SaveUserImageAsync(IFormFile ProfileImage);
    Task<bool> DeleteUserImageAsync(string imageUrl);
}

