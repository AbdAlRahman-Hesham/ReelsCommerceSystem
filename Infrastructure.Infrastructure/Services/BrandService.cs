using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class BrandService(IUnitOfWork _unitOfWork) : IBrandService
    {
        //public async Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req)
        //{
        //    bool isLiked;
        //    var review = await _unitOfWork.Repository<BrandReview>().GetByIdAsync(req.ReviewId);
        //    if (review == null)
        //        throw new Exception("Review not found.");
        //    var spec = new BrandReviewLikeSpec(userId, req);
        //    var reviewLike = await _unitOfWork.Repository<BrandReviewLike>().GetWithSpecAsync(spec);
        //    if (reviewLike == null)
        //    {
        //        var newLike = new BrandReviewLike
        //        {
        //            ReviewId = req.ReviewId,
        //            UserId = userId
        //        };
        //        await _unitOfWork.Repository<BrandReviewLike>().AddAsync(newLike);
        //        isLiked = true;
        //    }
        //    else
        //    {
        //        _unitOfWork.Repository<BrandReviewLike>().Delete(reviewLike);
        //        isLiked = false;
        //    }
        //    await _unitOfWork.Repository<BrandReviewLike>().SaveChangesAsync();
        //    var reviewLikes = await _unitOfWork.Repository<BrandReviewLike>()
        //        .GetAllWithSpecAsync(new BrandReviewLikeSpec(req));
        //    var totalLikes = reviewLikes.Count();
        //    return new ToggleLikeRes
        //    {
        //        ReviewId = req.ReviewId,
        //        IsLiked = isLiked,
        //        TotalLikes = totalLikes
        //    };

        //}
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

                review.numOfLikes += 1;
                isLiked = true;
            }
            else
            {
                // Remove like
                _unitOfWork.Repository<BrandReviewLike>().Delete(reviewLike);

                review.numOfLikes = Math.Max(0, review.numOfLikes - 1);
                isLiked = false;
            }

            _unitOfWork.Repository<BrandReview>().Update(review);
            await _unitOfWork.SaveChangesAsync();

            var totalLikes = review.numOfLikes;

            return new ToggleLikeRes
            {
                ReviewId = req.ReviewId,
                IsLiked = isLiked,
                TotalLikes = totalLikes
            };
        }
    public class BrandService: IBrandService
    {
        private readonly AppDbContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(AppDbContext dbContext,IUnitOfWork unitOfWork)
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId)
        {
           var brand=await _dbContext.Brands.AsNoTracking()
                 .Include(b => b.Products)
                    .ThenInclude(p => p.Reels)
                .Include(b => b.UserFollows)
                .FirstOrDefaultAsync(b => b.Id == brandId);
            if(brand == null)
            {
                return ApiResponse<BrandInfoRes>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found", "العلامة التجارية غير موجودة.");

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

        public async Task<string?> GetBrandPolicyAsync(int brandId)

        {

            var brandRepo = _unitOfWork.Repository<Brand>();

            var spec = new BrandByIdSpec(brandId);
            var brand = await brandRepo.GetWithSpecAsync(spec);
            if (brand == null)
                return null;
            return brand.ReturnPolicyAsHtml;

        }
    }
}
