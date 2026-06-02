using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class CloudinaryService : ICloudinaryService
{
    private readonly Cloudinary _cloudinary;

    public CloudinaryService(IOptions<CloudinarySettings> config)
    {
        var account = new Account(
            config.Value.CloudName,
            config.Value.ApiKey,
            config.Value.ApiSecret
        );

        _cloudinary = new Cloudinary(account);
    }

    public async Task<string> UploadImageAsync(
        IFormFile file,
        string folder = "posts")
    {
        ValidateImage(file);

        await using var stream = file.OpenReadStream();

        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, stream),
            Folder = folder
        };

        var result = await _cloudinary.UploadAsync(uploadParams);

        if (result.Error != null)
            throw new Exception(result.Error.Message);

        return result.SecureUrl.ToString();
    }

    public async Task<string> UploadVideoAsync(
        IFormFile file,
        string folder = "reels")
    {
        ValidateVideo(file);

        await using var stream = file.OpenReadStream();

        var uploadParams = new VideoUploadParams
        {
            File = new FileDescription(file.FileName, stream),
            Folder = folder
        };

        var result = await _cloudinary.UploadAsync(uploadParams);

        if (result.Error != null)
            throw new Exception(result.Error.Message);

        return result.SecureUrl.ToString();
    }

    private static void ValidateImage(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new Exception("Invalid image file");

        if (!file.ContentType.StartsWith("image"))
            throw new Exception("Only image files are allowed");
    }

    private static void ValidateVideo(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new Exception("Invalid video file");

        if (!file.ContentType.StartsWith("video"))
            throw new Exception("Only video files are allowed");
    }
}