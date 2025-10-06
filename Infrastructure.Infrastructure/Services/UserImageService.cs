using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.Interfaces.Services;


namespace ReelsCommerceSystem.Infrastructure.Services;

public class UserImageService(string _webRootPath) : IUserImageService
{
    

    public async Task<string> SaveUserImageAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return null;

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        var relativePath = Path.Combine("images", "users", fileName);
        var fullPath = Path.Combine(_webRootPath, relativePath);

        var directory = Path.GetDirectoryName(fullPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        using (var stream = new FileStream(fullPath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return relativePath.Replace("\\", "/");
    }
}

