using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
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

        public async Task<List<ReelFeedRes>> ReelsForUserFollowingAsync(string userId)
        {
            var user = await _user.Users.Include(u=>u.BrandFollows).ThenInclude(bf=>bf.Brand).
                FirstOrDefaultAsync(u=>u.Id==userId);
            var followedIds =user.BrandFollows.Select(b => b.BrandId).ToList();
            var spec = new ReelFeedSpec(followedIds);

            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            return reels.Select(r => new ReelFeedRes
            {
                ReelId = r.Id,
                VideoUrl = r.VideoUrl,
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches,
                NumOfComments = r.ReelComments.Count,
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
                }).ToList()
            }).ToList();
            }

        public async Task<List<ReelFeedRes>> ReelsWithRecommendationSystemAsync(string userId)
        {
            // TEMPORARY UNTIL AI INTEGRATION
            var spec = new ReelFeedSpec();

            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            return reels.Select(r => new ReelFeedRes
            {
                ReelId = r.Id,
                VideoUrl = r.VideoUrl,
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches,
                NumOfComments = r.ReelComments.Count,
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
                }).ToList()
            }).ToList();
        }
    }
}
