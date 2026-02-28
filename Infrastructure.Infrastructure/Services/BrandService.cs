using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;

using System.Net;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace ReelsCommerceSystem.Infrastructure.Services;
public class BrandService : IBrandService
{
    private readonly AppDbContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;

    public BrandService(AppDbContext dbContext, IUnitOfWork unitOfWork)
    {
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
    }

    public async Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req)
    {
        var review = await _unitOfWork.Repository<BrandReview>().GetByIdAsync(req.ReviewId);
        if (review == null)
            throw new Exception("Review not found.");

        var spec = new BrandReviewLikeSpec(userId, req);
        var reviewLike = await _unitOfWork.Repository<BrandReviewLike>().GetWithSpecAsync(spec);

        bool isLiked;

        if (reviewLike == null)
        {
            // Add new like
            var newLike = new BrandReviewLike
            {
                ReviewId = req.ReviewId,
                UserId = userId
            };

            await _unitOfWork.Repository<BrandReviewLike>().AddAsync(newLike);
            review.NumOfLikes += 1;
            isLiked = true;
        }
        else
        {
            // Remove like
            _unitOfWork.Repository<BrandReviewLike>().Delete(reviewLike);
            review.NumOfLikes = Math.Max(0, review.NumOfLikes - 1);
            isLiked = false;
        }

        _unitOfWork.Repository<BrandReview>().Update(review);
        await _unitOfWork.SaveChangesAsync();

        return new ToggleLikeRes
        {
            ReviewId = req.ReviewId,
            IsLiked = isLiked,
            TotalLikes = review.NumOfLikes
        };
    }

    public async Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId)
    {
        var brand = await _dbContext.Brands.AsNoTracking()
            .Include(b => b.Products)
                .ThenInclude(p => p.ProductReels)
                .ThenInclude(pr => pr.Reel)
            .Include(b => b.UserFollows)
            .FirstOrDefaultAsync(b => b.Id == brandId);

        if (brand == null)
        {
            return ApiResponse<BrandInfoRes>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found",
                "العلامة التجارية غير موجودة."
            );
        }

        var totalLikes = brand.Products
                         .SelectMany(p => p.ProductReels)
                         .Select(pr => pr.Reel)
                         .Sum(r => r.NumOfLikes);

        var followersCount = brand.UserFollows?.Count ?? 0;

        var result = new BrandInfoRes
        {
            DisplayName = brand.DisplayName ?? string.Empty,
            LogoUrl = brand.LogoUrl ?? string.Empty,
            FollowersCount = followersCount,
            TotalReelLikes = totalLikes
        };

        return ApiResponse<BrandInfoRes>.SuccessResponse(result, HttpStatusCode.OK);
    }
    public async Task<ToggleDislikeRes> BrandReviewDislikeAsync(string userId, ToggleDislikeReq req)
    {
        var review = await _unitOfWork.Repository<BrandReview>().GetByIdAsync(req.ReviewId);
        if (review == null)
            throw new Exception("Review not found.");

        var spec = new BrandReviewDislikeSpec(userId, req);
        var reviewLike = await _unitOfWork.Repository<BrandReviewDislikes>().GetWithSpecAsync(spec);

        bool isLiked;

        if (reviewLike == null)
        {
            // Add new like
            var newLike = new BrandReviewDislikes
            {
                ReviewId = req.ReviewId,
                UserId = userId
            };

            await _unitOfWork.Repository<BrandReviewDislikes>().AddAsync(newLike);
            review.NumOfDislikes += 1;
            isLiked = true;
        }
        else
        {
            // Remove like
            _unitOfWork.Repository<BrandReviewDislikes>().Delete(reviewLike);
            review.NumOfDislikes = Math.Max(0, review.NumOfDislikes - 1);
            isLiked = false;
        }

        _unitOfWork.Repository<BrandReview>().Update(review);
        await _unitOfWork.SaveChangesAsync();

        return new ToggleDislikeRes
        {
            ReviewId = req.ReviewId,
            IsDisliked = isLiked,
            TotalDislikes = review.NumOfDislikes
        };
    }
    public async Task<string?> GetBrandPolicyAsync(int brandId)
    {
        var brandRepo = _unitOfWork.Repository<Brand>();
        var spec = new BrandByIdSpec(brandId);
        var brand = await brandRepo.GetWithSpecAsync(spec);

        return brand?.ReturnPolicyAsHtml;
    }
    public async Task<ApiResponse<BrandFollowResponse>> ToggleFollowAsync(int brandId, string userId)
    {
        var brand = await _dbContext.Brands
            .Include(b => b.UserFollows)
            .FirstOrDefaultAsync(b => b.Id == brandId);
        if (brand == null)
        {
            return ApiResponse<BrandFollowResponse>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found", "" +
                 "العلامة التجارية غير موجودة.");
        }
        var existingFollow = await _dbContext.UserBrandFollows.FirstOrDefaultAsync(f => f.BrandId == brandId && f.UserId == userId);
        bool isNowFollowing;
        string enMessage;
        string arMessage;
        if (existingFollow != null)
        {
            _dbContext.UserBrandFollows.Remove(existingFollow);
            await _dbContext.SaveChangesAsync();
            isNowFollowing = false;
            enMessage = "You have unfollowed this brand.";
            arMessage = "تم إلغاء متابعة العلامة التجارية.";
        }
        else
        {
            var newFollow = new UserBrandFollow
            {
                BrandId = brandId,
                UserId = userId,
                FollowedAt = DateTime.UtcNow
            };
            _dbContext.UserBrandFollows.Add(newFollow);
            await _dbContext.SaveChangesAsync();
            isNowFollowing = true;
            enMessage = "You are now following this brand.";
            arMessage = "تم متابعة العلامة التجارية بنجاح.";
        }
        var TotalFollowers = await _dbContext.UserBrandFollows.CountAsync(f => f.BrandId == brandId);
        var response = new BrandFollowResponse
        {
            BrandId = brand.Id,
            BrandDisplayName = brand.DisplayName,
            BrandLogoUrl = brand.LogoUrl,
            IsFollowed = isNowFollowing,
            TotalFollowers = TotalFollowers,
            Message = isNowFollowing ? "Followed successfully" : "Unfollowed successfully"

        };
        return ApiResponse<BrandFollowResponse>.SuccessResponse(
               response,
               HttpStatusCode.OK,
               enMessage,
               arMessage
            );
    }
    public async Task<ApiResponse<string>> AddOrUpdateReview(
                int brandId,
                string userId,
                BrandReviewReq dto)
    {
        
        var brandSpec = new BrandByIdSpec(brandId);

        var brand = await _unitOfWork
            .Repository<Brand>()
            .GetWithSpecAsync(brandSpec);   

        if (brand == null)
        {
            return ApiResponse<string>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found.",
                "البراند غير موجود."
            );
        }

        var reviewSpec = new BrandReviewByUserSpec(brandId, userId);

        var existingReview = await _unitOfWork
            .Repository<BrandReview>()
            .GetWithSpecAsync(reviewSpec);

        HttpStatusCode statusCode;
        string enMessage;
        string arMessage;

        if (existingReview == null)
        {
            var review = new BrandReview
            {
                BrandId = brandId,
                UserId = userId,
                Rating = dto.Rating,
                Comment = dto.Comment
            };

            await _unitOfWork
                .Repository<BrandReview>()
                .AddAsync(review);

            brand.AverageRating = (brand.AverageRating * brand.NumOfReviews + dto.Rating)
                              / (brand.NumOfReviews + 1);

            brand.NumOfReviews += 1;

            statusCode = HttpStatusCode.Created;
            enMessage = "Review added successfully.";
            arMessage = "تم إضافة التقييم بنجاح.";
        }
        else
        {
            int oldRating = existingReview.Rating;
            existingReview.Rating = dto.Rating;
            existingReview.Comment = dto.Comment;

            _unitOfWork
                .Repository<BrandReview>()
                .Update(existingReview);

            brand.AverageRating = (brand.AverageRating * brand.NumOfReviews - oldRating + dto.Rating)
                             / brand.NumOfReviews;

            statusCode = HttpStatusCode.OK;
            enMessage = "Review updated successfully.";
            arMessage = "تم تعديل التقييم بنجاح.";
        }


        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<string>.SuccessResponse(
            "Success",
            statusCode,
            enMessage,
            arMessage
        );
    }
    public async Task<ApiResponse<double>> GetAverageRating(int brandId)
    {
        var spec = new BrandByIdSpec(brandId); 
        var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(spec);
        if (brand == null)
            return ApiResponse<double>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found.", "البراند غير موجود.");
        double avg = brand.NumOfReviews > 0 ? brand.AverageRating : 0;

        return ApiResponse<double>.SuccessResponse(avg, HttpStatusCode.OK);
    }
}