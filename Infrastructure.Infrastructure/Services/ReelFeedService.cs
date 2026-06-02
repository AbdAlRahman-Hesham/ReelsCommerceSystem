using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReelFeedService : IReelFeedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _user;
        private readonly IRecommendationService _recommendationService;


        public ReelFeedService(IUnitOfWork unitOfWork, UserManager<User> user, IRecommendationService recommendationService)
        {
            _unitOfWork = unitOfWork;
            _user = user;
            _recommendationService = recommendationService;
        }
        public async Task<PaginationResponse<ReelFeedRes>> ReelsForUserFollowingAsync(string userId, int pageIndex, int pageSize)
        {
            var user = await _user.Users
                .Include(u => u.BrandFollows)
                    .ThenInclude(bf => bf.Brand)
                .FirstOrDefaultAsync(u => u.Id == userId);

            var followedIds = user.BrandFollows.Select(b => b.BrandId).ToList();

            // Get paginated reels
            var spec = new ReelFeedSpec(followedIds, pageIndex, pageSize);
            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            // Count total records (without pagination)
            var totalReels = await _unitOfWork.Repository<Reel>()
                .CountAsync(new ReelFeedSpec(followedIds));

            // Get all likes for the user
            var reelLikes = await _unitOfWork.Repository<UserReelLike>().GetAllAsync();

            var reelsResult = reels.Select(r => new ReelFeedRes
            {
                ReelId = r.Id,
                VideoUrl = r.VideoUrl,
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches,
                NumOfComments = r.ReelComments.Count,
                BrandId = r.BrandId,
                BrandImageUrl = r.Brand.LogoUrl,
                BrandName = r.Brand.DisplayName,
                Products = r.ProductReels.Select(pr => pr.Product).Select(p => new ReelProductRes
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
                IsLiked = reelLikes.Any(like => like.UserId == userId && like.ReelId == r.Id)
            }).ToList();

            // Build pagination response
            return new PaginationResponse<ReelFeedRes>
            {
                Data = reelsResult,
                Meta = new Meta
                {
                    PageNumber = pageIndex,
                    PageSize = pageSize,
                    TotalRecords = totalReels,
                    HasPreviousPage = pageIndex > 1,
                    HasNextPage = pageIndex * pageSize < totalReels
                }
            };
        }
        public async Task<PaginationResponse<ReelFeedRes>> ReelsWithRecommendationSystemAsync(string userId, int pageIndex, int pageSize)
        {
            var recommendedIds = await _recommendationService.GetRecommendedReelIdsAsync(userId, topK: 100);

            List<Reel> reels;
            int totalReels;
            List<int> paginatedIds = new();

            if (recommendedIds != null && recommendedIds.Count > 0)
            {
                totalReels = recommendedIds.Count;
                paginatedIds = recommendedIds.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

                if (paginatedIds.Count > 0)
                {
                    var spec = new ReelFeedSpec(paginatedIds, filterByReelId: true);
                    var dbReels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

                    reels = dbReels.OrderBy(r => paginatedIds.IndexOf(r.Id)).ToList();
                }
                else
                {
                    reels = new List<Reel>();
                }
            }
            else
            {
                var spec = new ReelFeedSpec(pageIndex, pageSize);
                var dbReels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);
                reels = dbReels.ToList();
                totalReels = await _unitOfWork.Repository<Reel>().CountAsync(new ReelFeedSpec());
            }

            var likesSpec = new Specification<UserReelLike>(l => l.UserId == userId);
            var userLikes = await _unitOfWork.Repository<UserReelLike>().GetAllWithSpecAsync(likesSpec);

            var reelsResult = reels.Select(r => new ReelFeedRes
            {
                ReelId = r.Id,
                VideoUrl = r.VideoUrl,
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches,
                NumOfComments = r.ReelComments.Count,
                BrandId = r.BrandId,
                BrandImageUrl = r.Brand.LogoUrl,
                BrandName = r.Brand.DisplayName,
                Products = r.ProductReels.Select(pr => pr.Product).Select(p => new ReelProductRes
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
                IsLiked = userLikes.Any(like => like.ReelId == r.Id)
            }).ToList();

            return new PaginationResponse<ReelFeedRes>
            {
                Data = reelsResult,
                Meta = new Meta
                {
                    PageNumber = pageIndex,
                    PageSize = pageSize,
                    TotalRecords = totalReels,
                    HasPreviousPage = pageIndex > 1,
                    HasNextPage = pageIndex * pageSize < totalReels
                }
            };
        }


    }
}
