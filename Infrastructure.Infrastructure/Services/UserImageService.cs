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

        public async Task<bool> DeleteUserImageAsync(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl) || imageUrl.Contains("static.vecteezy.com"))
                return true;

            try
            {
                var uri = new Uri(imageUrl);
                var uploadIndex = imageUrl.IndexOf("/upload/");
                if (uploadIndex == -1) return false;

                var pathAfterUpload = imageUrl.Substring(uploadIndex + 8);
                if (pathAfterUpload.StartsWith("v") && char.IsDigit(pathAfterUpload[1]))
                {
                    var nextSlash = pathAfterUpload.IndexOf('/');
                    if (nextSlash != -1)
                    {
                        pathAfterUpload = pathAfterUpload.Substring(nextSlash + 1);
                    }
                }
                var publicId = Path.ChangeExtension(pathAfterUpload, null);

                var deletionParams = new DeletionParams(publicId);
                var result = await _cloudinary.DestroyAsync(deletionParams);
                return result.Result == "ok";
            }
            catch
            {
                return false;
            }
        }
    }
}



