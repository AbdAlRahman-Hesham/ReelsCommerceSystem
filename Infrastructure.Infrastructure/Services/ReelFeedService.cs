using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReelFeedService : IReelFeedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _user;
        private readonly IRecommendationService _recommendationService;
        private readonly IMemoryCache _cache;

        public ReelFeedService(
            IUnitOfWork unitOfWork,
            UserManager<User> user,
            IRecommendationService recommendationService,
            IMemoryCache cache)
        {
            _unitOfWork = unitOfWork;
            _user = user;
            _recommendationService = recommendationService;
            _cache = cache;
        }

        public async Task<PaginationResponse<ReelFeedRes>> ReelsForUserFollowingAsync(string userId, int pageIndex, int pageSize)
        {
            var user = await _user.Users
                .Include(u => u.BrandFollows)
                    .ThenInclude(bf => bf.Brand)
                .FirstOrDefaultAsync(u => u.Id == userId);

            var followedIds = user.BrandFollows.Select(b => b.BrandId).ToList();

            var spec = new ReelFeedSpec(followedIds, pageIndex, pageSize);
            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            var totalReels = await _unitOfWork.Repository<Reel>()
                .CountAsync(new ReelFeedSpec(followedIds));

            var likesSpec = new Specification<UserReelLike>(l => l.UserId == userId);
            var reelLikes = await _unitOfWork.Repository<UserReelLike>().GetAllWithSpecAsync(likesSpec);

            var reelsResult = MapToReelFeedRes(reels, reelLikes, userId);

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
            List<int> recommendedIds;
            if (!string.IsNullOrEmpty(userId))
            {
                recommendedIds = await _recommendationService.GetRecommendedReelIdsAsync(userId, topK: 100);
            }
            else
            {
                recommendedIds = new List<int>();
            }

            var seenIds = await GetCachedSeenReelIdsAsync(userId);
            var excludeForFallback = new HashSet<int>(recommendedIds);
            excludeForFallback.UnionWith(seenIds);

            var recSkip = (pageIndex - 1) * pageSize;
            var pageRecIds = recommendedIds.Skip(recSkip).Take(pageSize).ToList();

            List<Reel> pageReels;
            if (pageRecIds.Count > 0)
            {
                var recSpec = new ReelFeedSpec(pageRecIds, filterByReelId: true);
                var recReels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(recSpec);
                pageReels = recReels.OrderBy(r => pageRecIds.IndexOf(r.Id)).ToList();
            }
            else
            {
                pageReels = new List<Reel>();
            }

            var remainingSlots = pageSize - pageReels.Count;

            if (remainingSlots > 0)
            {
                var fallbackReels = await GetCachedFallbackReelsAsync(userId, excludeForFallback, remainingSlots);

                if (fallbackReels.Count < remainingSlots)
                {
                    var totalPublished = await GetCachedTotalPublishedCountAsync();
                    var unseenCount = totalPublished - excludeForFallback.Count;

                    if (unseenCount <= 0 || totalPublished < pageSize)
                    {
                        var lastResort = await GetLastResortReelsAsync(recommendedIds, remainingSlots - fallbackReels.Count);
                        fallbackReels.AddRange(lastResort);
                    }
                }

                pageReels.AddRange(fallbackReels);
            }

            var likesSpec = new Specification<UserReelLike>(l => l.UserId == userId);
            var userLikes = await _unitOfWork.Repository<UserReelLike>().GetAllWithSpecAsync(likesSpec);

            var reelsResult = MapToReelFeedRes(pageReels, userLikes, userId);

            var totalRecords = await GetCachedTotalPublishedCountAsync();

            return new PaginationResponse<ReelFeedRes>
            {
                Data = reelsResult,
                Meta = new Meta
                {
                    PageNumber = pageIndex,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    HasPreviousPage = pageIndex > 1,
                    HasNextPage = pageIndex * pageSize < totalRecords
                }
            };
        }

        #region Caching Helpers

        private async Task<T> GetOrSetCachedAsync<T>(string key, Func<Task<T>> factory, TimeSpan expiration)
        {
            if (_cache.TryGetValue(key, out T? cached) && cached is not null)
                return cached;

            var value = await factory();
            _cache.Set(key, value, new MemoryCacheEntryOptions().SetSlidingExpiration(expiration));
            return value;
        }

        private async Task<List<int>> GetCachedSeenReelIdsAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return new List<int>();

            return await GetOrSetCachedAsync(
                $"reel:feed:seen:{userId}",
                () => GetUserSeenReelIdsAsync(userId),
                TimeSpan.FromSeconds(30));
        }

        private async Task<List<Reel>> GetCachedFallbackReelsAsync(string userId, HashSet<int> excludeIds, int count)
        {
            var cacheKey = $"reel:feed:fallback:{userId ?? "anon"}:{count}";

            return await GetOrSetCachedAsync(
                cacheKey,
                () => GetFallbackReelsAsync(excludeIds, count),
                TimeSpan.FromSeconds(10));
        }

        private Task<int> GetCachedTotalPublishedCountAsync()
        {
            return GetOrSetCachedAsync(
                "reel:feed:totalCount",
                () => _unitOfWork.Repository<Reel>().CountAsync(new ReelFeedSpec(countOnly: true)),
                TimeSpan.FromMinutes(5));
        }

        #endregion

        #region Feed Helpers

        private async Task<List<int>> GetUserSeenReelIdsAsync(string userId)
        {
            var viewSpec = new Specification<UserReelView>(v => v.UserId == userId);
            var views = await _unitOfWork.Repository<UserReelView>().GetAllWithSpecAsync(viewSpec);
            return views.Select(v => v.ReelId).Distinct().ToList();
        }

        private async Task<List<Reel>> GetFallbackReelsAsync(HashSet<int> excludeIds, int count)
        {
            var bufferSize = Math.Max(count * 3, 30);
            var spec = new ReelFeedSpec(excludeIds, pageIndex: 1, pageSize: bufferSize);
            var candidates = (await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec)).ToList();

            if (candidates.Count == 0)
                return new List<Reel>();

            var latest = candidates;
            var viewed = candidates.OrderByDescending(r => r.NumOfWatches).ToList();
            var liked = candidates.OrderByDescending(r => r.NumOfLikes).ToList();

            var result = new List<Reel>();
            var seenSet = new HashSet<int>(excludeIds);

            for (int i = 0; i < bufferSize && result.Count < count; i++)
            {
                if (i < latest.Count && seenSet.Add(latest[i].Id))
                    result.Add(latest[i]);

                if (result.Count >= count) break;

                if (i < viewed.Count && seenSet.Add(viewed[i].Id))
                    result.Add(viewed[i]);

                if (result.Count >= count) break;

                if (i < liked.Count && seenSet.Add(liked[i].Id))
                    result.Add(liked[i]);
            }

            return result;
        }

        private async Task<List<Reel>> GetLastResortReelsAsync(List<int> recommendedIds, int count)
        {
            if (count <= 0) return new List<Reel>();

            var excludeSet = new HashSet<int>(recommendedIds);
            var spec = new ReelFeedSpec(excludeSet, pageIndex: 1, pageSize: count);
            return (await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec)).ToList();
        }

        #endregion

        #region Mapping

        private static List<ReelFeedRes> MapToReelFeedRes(IReadOnlyList<Reel> reels, IReadOnlyList<UserReelLike> userLikes, string userId)
        {
            return reels.Select(r => new ReelFeedRes
            {
                ReelId = r.Id,
                Title = r.Title,
                VideoUrl = r.VideoUrl,
                ThumbnailUrl = r.ThumbnailUrl ?? FileHelper.GenerateThumbnailUrl(r.VideoUrl),
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches,
                NumOfShares = r.NumOfShares,
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
                IsLiked = userLikes.Any(like => like.UserId == userId && like.ReelId == r.Id)
            }).ToList();
        }

        #endregion
    }
}
