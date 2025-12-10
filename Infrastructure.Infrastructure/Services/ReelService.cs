using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Request.Reel;
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
        var spec = new Specification<UserReelLike>(criteria: like => like.UserId == userId && like.ReelId == reelId);

        var existingLike = await _unitOfWork.Repository<UserReelLike>().GetWithSpecAsync(spec);

        bool isLiked;

        if (existingLike == null)
        {
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
    public async Task<ApiResponse<string>> TrackReelViewAsync(string userId, ReelViewReq req)
    {
        var reel = await _unitOfWork.Repository<Reel>().GetByIdAsync(req.ReelId);
        if (reel == null)
        {
            return ApiResponse<string>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Reel Not Found",
                "الريل غير موجود"
            );
        }

        var spec = new Specification<UserReelView>(criteria: view => view.UserId == userId && view.ReelId ==req.ReelId);

        var existingView = await _unitOfWork.Repository<UserReelView>().GetWithSpecAsync(spec);

        if (existingView == null)
        {
            var newView = new UserReelView
            {
                UserId = userId,
                ReelId = req.ReelId,
                WatchedDurationSeconds = req.WatchedDurationSeconds,
                VideoDurationSeconds = req.VideoDurationSeconds
            };

            await _unitOfWork.Repository<UserReelView>().AddAsync(newView);
        }
        else
        {
            existingView.WatchedDurationSeconds = req.WatchedDurationSeconds;
            existingView.VideoDurationSeconds = req.VideoDurationSeconds;

            _unitOfWork.Repository<UserReelView>().Update(existingView);
        }

        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<string>.SuccessResponse(
            "View Recorded Successfully",
            HttpStatusCode.OK
        );
    }

}


