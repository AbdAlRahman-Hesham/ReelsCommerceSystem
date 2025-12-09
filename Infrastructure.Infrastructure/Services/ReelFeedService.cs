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

        public ReelFeedService(IUnitOfWork unitOfWork,UserManager<User> user)
        {
            _unitOfWork = unitOfWork;
            _user = user;
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
                    MediaUrl = p.MediaUrl,
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
            // Paginated reels
            var spec = new ReelFeedSpec(pageIndex, pageSize);
            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            // Total reels without pagination
            var totalReels = await _unitOfWork.Repository<Reel>()
                .CountAsync(new ReelFeedSpec());

            // Likes
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
                    MediaUrl = p.MediaUrl,
                    DiscountPercentage = p.DiscountPercentage,
                    HaveOffer = p.HaveOffer,
                    Rate = p.Reviews.Any() ? (int)Math.Round(p.Reviews.Average(rv => rv.Rating)) : 0
                }).ToList(),
                IsLiked = reelLikes.Any(like => like.UserId == userId && like.ReelId == r.Id)
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


        /*public async Task<List<ReelFeedRes>> ReelsForUserFollowingAsync(string userId, int pageIndex, int pageSize)
        {
            var user = await _user.Users.Include(u=>u.BrandFollows).ThenInclude(bf=>bf.Brand).
                FirstOrDefaultAsync(u=>u.Id==userId);
            var followedIds =user.BrandFollows.Select(b => b.BrandId).ToList();
            var spec = new ReelFeedSpec(followedIds,pageIndex,pageSize);

            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);
            var reelLikes = await _unitOfWork.Repository<UserReelLike>().GetAllAsync();
            //count
            var withoutPaginationSpec = new ReelFeedSpec(followedIds);
            var reelsWithoutPagination= await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(withoutPaginationSpec);
            var totalReels=reelsWithoutPagination.Count;

            return reels.Select(r => new ReelFeedRes
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
                Products = r.ProductReels
                .Select(pr => pr.Product)
                .Select(p => new ReelProductRes
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    MediaUrl = p.MediaUrl,
                    DiscountPercentage = p.DiscountPercentage,
                    HaveOffer = p.HaveOffer,
                    Rate = p.Reviews.Any() ?
                                    (int)Math.Round(p.Reviews.Average(r => r.Rating)) : 0
                }).ToList(),
                IsLiked = reelLikes.Where(like => like.UserId == userId && like.ReelId == r.Id).Any()
            }).ToList();
            }
        */
        /*public async Task<List<ReelFeedRes>> ReelsWithRecommendationSystemAsync(string userId, int pageIndex, int pageSize)
        {
            // TEMPORARY UNTIL AI INTEGRATION
            var spec = new ReelFeedSpec(pageIndex,pageSize);

            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);
            var reelLikes = await _unitOfWork.Repository<UserReelLike>().GetAllAsync();
            //count
            var withoutPaginationSpec = new ReelFeedSpec();
            var reelsWithoutPagination = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(withoutPaginationSpec);
            var totalReels = reelsWithoutPagination.Count;


            return reels.Select(r => new ReelFeedRes
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
                Products = r.ProductReels
                .Select(pr => pr.Product)
                .Select(p => new ReelProductRes
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    MediaUrl = p.MediaUrl,
                    DiscountPercentage = p.DiscountPercentage,
                    HaveOffer = p.HaveOffer,
                    Rate = p.Reviews.Any() ?
                                    (int)Math.Round(p.Reviews.Average(r => r.Rating)) : 0
                }).ToList(),
                IsLiked = reelLikes.Where(like => like.UserId == userId && like.ReelId == r.Id).Any()
            }).ToList();
        }*/
    }
}
