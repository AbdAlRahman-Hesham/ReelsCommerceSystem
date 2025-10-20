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
                .ThenInclude(p => p.Reels)
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
            .SelectMany(p => p.Reels ?? Enumerable.Empty<Reel>())
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
    
   /* public async Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId)
    {
        var brand = await _dbContext.Brands.AsNoTracking()
            .Include(b => b.Products)
                .ThenInclude(p => p.Reels)
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
            .SelectMany(p => p.Reels ?? Enumerable.Empty<Reel>())
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
    }*/

    public async Task<string?> GetBrandPolicyAsync(int brandId)
    {
        var brandRepo = _unitOfWork.Repository<Brand>();
        var spec = new BrandByIdSpec(brandId);
        var brand = await brandRepo.GetWithSpecAsync(spec);

        return brand?.ReturnPolicyAsHtml;
    }
}
