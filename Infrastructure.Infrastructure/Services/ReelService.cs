using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class ReelService(IUnitOfWork _unitOfWork,UserManager<User> _userManager) : IReelService

{
    public async Task<ApiResponse<List<AllReelsInBrandRes>>> GetReelsByBrandAsync(int brandId, string? sortBy)

    {
        var brandExists = await _unitOfWork.Repository<Brand>().GetByIdAsync(brandId);

        if (brandExists is null)
        {
            return ApiResponse<List<AllReelsInBrandRes>>.ErrorResponse(
                HttpStatusCode.NotFound,
            en: "Brand not found.",
            ar: "العلامة التجارية غير موجودة.",
            errors: new List<ValidationError>
            {
                new ValidationError
                {
                    Field = "brandId",
                    En = "The provided brand ID does not exist.",
                    Ar = "معرف العلامة التجارية غير موجود."
                }
            }
        );

        }
        var spec = new ReelsByBrandWithSortingSpec(brandId, sortBy);
        var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);
        var AllReels = new List<AllReelsInBrandRes>();
        foreach (var reel in reels)
        {
            var result = new AllReelsInBrandRes
            {
                ReelId= reel.Id,
                ThumbnailUrl= GenerateThumbnailUrl(reel.VideoUrl),
                NumOfLikes=reel.NumOfLikes,
                NumOfWatches=reel.NumOfWatches,
                CreatedAt=reel.CreatedAt,
                VideoUrl=reel.VideoUrl,
                Title=reel.Title//////////

            };
            AllReels.Add(result);

        }
        return ApiResponse<List<AllReelsInBrandRes>>
            .SuccessResponse
            (
                               AllReels,
                               HttpStatusCode.OK,
                               en: "Request completed successfully.",
                               ar: "تم تنفيذ الطلب بنجاح."
            );

    }

    private string GenerateThumbnailUrl(string videoUrl, int second = 1)
    {
        if (string.IsNullOrWhiteSpace(videoUrl))
            throw new ArgumentException("Video URL cannot be empty");

        var split = videoUrl.Split("/video/upload/");
        if (split.Length != 2)
            throw new Exception("Invalid Cloudinary URL format");

        var prefix = split[0];
        var suffix = split[1];

        if (suffix.EndsWith(".mp4"))
            suffix = suffix[..^4] + ".jpg";

        string transform = $"video/upload/so_{second},f_jpg/";

        return $"{prefix}/{transform}{suffix}";
    }
    public async Task<bool> ToggleReelLikeAsync(string userId, int reelId)
    {
        var specs = new Specification<UserReelLike>(criteria: x => x.UserId == userId && x.ReelId == reelId);

        var existingLike = await _unitOfWork.Repository<UserReelLike>().GetWithSpecAsync(specs);

        bool isLiked;

        if (existingLike == null)
        {
            var user = await _userManager.FindByIdAsync(userId);
            // Add new like
            var newLike = new UserReelLike
            {
                ReelId = reelId,
                UserId = userId
            };

            await _unitOfWork.Repository<UserReelLike>().AddAsync(newLike);
            isLiked = true;
        }
        else
        {
            // Remove like
            _unitOfWork.Repository<UserReelLike>().Delete(existingLike);
            isLiked = false;
        }

        await _unitOfWork.SaveChangesAsync();

        return isLiked;

    }
}


