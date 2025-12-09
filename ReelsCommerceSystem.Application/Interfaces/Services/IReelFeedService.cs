using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReelFeedService
    {
        Task<List<ReelFeedRes>> ReelsWithRecommendationSystemAsync(string userId, int pageIndex, int pageSize);
        Task<List<ReelFeedRes>> ReelsForUserFollowingAsync(string userId, int pageIndex, int pageSize);
    }
}
