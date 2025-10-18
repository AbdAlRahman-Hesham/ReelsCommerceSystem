using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class UserImageService : IUserImageService
    {
        private readonly Cloudinary _cloudinary;

        public UserImageService(Cloudinary cloudinary)
        {
            _cloudinary = cloudinary;
        }

        public async Task<string?> SaveUserImageAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            await using var stream = file.OpenReadStream();

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Folder = "reels-commerce/users", // custom folder path in Cloudinary
                PublicId = Guid.NewGuid().ToString(),
                Transformation = new Transformation()
                    .Quality("auto")
                    .FetchFormat("auto")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            return uploadResult?.SecureUrl?.ToString();
        }
    }
}


