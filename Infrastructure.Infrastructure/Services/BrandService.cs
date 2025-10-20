using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services
{
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

        public async Task<ApiResponse<BrandFollowResponse>> ToggleFollowAsync(int brandId, string userId)
        {
            var brand = await _dbContext.Brands
                .Include(b => b.UserFollows)
                .FirstOrDefaultAsync(b => b.Id == brandId);
            if(brand == null)
            {
                return ApiResponse<BrandFollowResponse>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found", "" +
                     "العلامة التجارية غير موجودة.");
            }
            var existingFollow = await _dbContext.UserBrandFollows.FirstOrDefaultAsync(f => f.BrandId == brandId && f.UserId == userId);
            bool isNowFollowing;
            string enMessage;
            string arMessage;
            if(existingFollow != null)
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
    }
}
