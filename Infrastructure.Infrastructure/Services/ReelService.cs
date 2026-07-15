using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReelsCommerceSystem.Application.DTOs.Request.Reel;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class ReelService(IUnitOfWork _unitOfWork, IRecommendationService _recommendationService, ILogger<ReelService> _logger) : IReelService

{
    public async Task<ApiResponse<List<AllReelsInBrandRes>>> GetReelsByBrandAsync(int brandId, string? sortBy, string? userId = null)

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

        bool includeDrafts = false;
        if (userId is not null)
        {
            var brandSpec = new GetBrandByUserId(userId);
            var userBrand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);
            if (userBrand is not null && userBrand.Id == brandId)
                includeDrafts = true;
        }

        var spec = new ReelsByBrandWithSortingSpec(brandId, sortBy, includeDrafts);
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
                NumOfShares=reel.NumOfShares,
                IsLiked= userId is not null && reel.UserReelLikes.Any(l => l.UserId == userId),
                CreatedAt=reel.CreatedAt,
                VideoUrl=reel.VideoUrl,
                Title=reel.Title

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

    public async Task<ApiResponse<ReelFeedRes>> GetReelByIdAsync(int reelId, string? userId = null)
    {
        var spec = new ReelFeedSpec(new List<int> { reelId }, filterByReelId: true);
        var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);
        var reel = reels.FirstOrDefault();

        if (reel is null)
        {
            return ApiResponse<ReelFeedRes>.ErrorResponse(
                HttpStatusCode.NotFound,
                en: "Reel not found.",
                ar: "الريل غير موجود",
                errors: new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "reelId",
                        En = "The provided reel ID does not exist.",
                        Ar = "معرف الريل غير موجود."
                    }
                }
            );
        }

        bool isLiked = false;
        if (!string.IsNullOrEmpty(userId))
        {
            var likeSpec = new Specification<UserReelLike>(l => l.UserId == userId && l.ReelId == reelId);
            isLiked = await _unitOfWork.Repository<UserReelLike>().GetWithSpecAsync(likeSpec) != null;
        }

        var result = new ReelFeedRes
        {
            ReelId = reel.Id,
            Title = reel.Title,
            VideoUrl = reel.VideoUrl,
            ThumbnailUrl = reel.ThumbnailUrl ?? GenerateThumbnailUrl(reel.VideoUrl),
            CreatedAt = reel.CreatedAt,
            NumOfLikes = reel.NumOfLikes,
            NumOfWatches = reel.NumOfWatches,
            NumOfShares = reel.NumOfShares,
            NumOfComments = reel.ReelComments.Count,
            BrandId = reel.BrandId,
            BrandImageUrl = reel.Brand.LogoUrl,
            BrandName = reel.Brand.DisplayName,
            Products = reel.ProductReels.Select(pr => pr.Product).Select(p => new ReelProductRes
            {
                ProductId = p.Id,
                ProductName = p.Name,
                Price = p.Price,
                ProductMediaUrls = p.Images?
                                   .Where(x => x.Url != null)
                                   .Select(x => x.Url)
                                   .ToList() ?? new List<string>(),
                DiscountPercentage = p.DiscountPercentage,
                HaveOffer = p.HaveOffer,
                Rate = p.Reviews.Any() ? (int)Math.Round(p.Reviews.Average(rv => rv.Rating)) : 0
            }).ToList(),
            IsLiked = isLiked
        };

        return ApiResponse<ReelFeedRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            en: "Reel loaded successfully.",
            ar: "تم تحميل الريل بنجاح."
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
    public async Task<ApiResponse<bool>> ToggleReelLikeAsync(string userId, int reelId)
    {
        var reel = await _unitOfWork.Repository<Reel>().GetByIdAsync(reelId);
        if (reel is null)
        {
            return ApiResponse<bool>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Reel not found.",
                "الريل غير موجود",
                errors:
                [
                    new ValidationError
                    {
                        Field = "reelId",
                        En = "The provided reel ID does not exist.",
                        Ar = "معرف الريل غير موجود."
                    }
                ]
            );
        }

        var spec = new Specification<UserReelLike>(criteria: like => like.UserId == userId && like.ReelId == reelId);

        var existingLike = await _unitOfWork.Repository<UserReelLike>().GetWithSpecAsync(spec);

        bool isLiked;

        if (existingLike == null)
        {
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
            _unitOfWork.Repository<UserReelLike>().Delete(existingLike);
            isLiked = false;
        }

        await _unitOfWork.SaveChangesAsync();

        // Update recommendation engine with new counts
        var reelWithCounts = await _unitOfWork.Repository<Reel>().GetByIdAsync(reelId);
        if (reelWithCounts != null)
        {
            var likesCount = await _unitOfWork.Repository<UserReelLike>()
                .CountAsync(new Specification<UserReelLike>(l => l.ReelId == reelId));
            var viewsCount = await _unitOfWork.Repository<UserReelView>()
                .CountAsync(new Specification<UserReelView>(v => v.ReelId == reelId));
            _ = _recommendationService.UpdateReelMetadataAsync(reelId, likesCount, viewsCount);
        }

        return ApiResponse<bool>.SuccessResponse(
            isLiked,
            HttpStatusCode.OK,
            en: isLiked ? "Like added successfully." : "Like removed successfully.",
            ar: isLiked ? "تم إضافة الإعجاب بنجاح." : "تم إزالة الإعجاب بنجاح."
        );

    }
    private const double MinViewThresholdSeconds = 1.0; // tune this, or use a % of VideoDurationSeconds

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

        var spec = new Specification<UserReelView>(
            criteria: view => view.UserId == userId && view.ReelId == req.ReelId);

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

            try
            {
                await _unitOfWork.Repository<UserReelView>().AddAsync(newView);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Another request inserted the same (UserId, ReelId) pair first
                // (requires a unique index on UserId+ReelId for this to trigger reliably).
                existingView = await _unitOfWork.Repository<UserReelView>().GetWithSpecAsync(spec);
                if (existingView != null)
                {
                    existingView.WatchedDurationSeconds = Math.Max(
                        existingView.WatchedDurationSeconds, req.WatchedDurationSeconds);
                    existingView.VideoDurationSeconds = req.VideoDurationSeconds;

                    _unitOfWork.Repository<UserReelView>().Update(existingView);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
        }
        else
        {
            var newWatchedDuration = Math.Max(existingView.WatchedDurationSeconds, req.WatchedDurationSeconds);
            var hasChanged = newWatchedDuration != existingView.WatchedDurationSeconds
                || existingView.VideoDurationSeconds != req.VideoDurationSeconds;

            if (hasChanged)
            {
                existingView.WatchedDurationSeconds = newWatchedDuration;
                existingView.VideoDurationSeconds = req.VideoDurationSeconds;

                _unitOfWork.Repository<UserReelView>().Update(existingView);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        // Only feed the recommendation engine when the watch crosses a meaningful threshold
        if (req.WatchedDurationSeconds >= MinViewThresholdSeconds)
        {
            var likesCount = await _unitOfWork.Repository<UserReelLike>()
                .CountAsync(new Specification<UserReelLike>(l => l.ReelId == req.ReelId));
            var viewsCount = await _unitOfWork.Repository<UserReelView>()
                .CountAsync(new Specification<UserReelView>(v => v.ReelId == req.ReelId));

            _ = Task.Run(async () =>
            {
                try
                {
                    await _recommendationService.UpdateReelMetadataAsync(req.ReelId, likesCount, viewsCount);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to update recommendation metadata for reel {ReelId}", req.ReelId);
                }
            });
        }

        return ApiResponse<string>.SuccessResponse(
            "View Recorded Successfully",
            HttpStatusCode.OK
        );
    }

    public async Task<ApiResponse<int>> TrackReelShareAsync(string userId, int reelId)
    {
        var reel = await _unitOfWork.Repository<Reel>().GetByIdAsync(reelId);
        if (reel == null)
        {
            return ApiResponse<int>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Reel not found.",
                "الريل غير موجود",
                errors: new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "reelId",
                        En = "The provided reel ID does not exist.",
                        Ar = "معرف الريل غير موجود."
                    }
                }
            );
        }

        var newShare = new UserReelShare
        {
            UserId = userId,
            ReelId = reelId
        };

        await _unitOfWork.Repository<UserReelShare>().AddAsync(newShare);
        await _unitOfWork.SaveChangesAsync();

        var shareCount = await _unitOfWork.Repository<UserReelShare>()
            .CountAsync(new Specification<UserReelShare>(s => s.ReelId == reelId));

        return ApiResponse<int>.SuccessResponse(
            shareCount,
            HttpStatusCode.OK,
            en: "Share recorded successfully.",
            ar: "تم تسجيل المشاركة بنجاح."
        );
    }

}


