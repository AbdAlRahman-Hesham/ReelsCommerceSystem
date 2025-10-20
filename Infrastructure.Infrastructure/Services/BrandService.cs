using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
