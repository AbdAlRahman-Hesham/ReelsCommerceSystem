using ReelsCommerceSystem.Application.DTOs.Request.Reel;
using ReelsCommerceSystem.Application.DTOs.Response.Reel;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReelService
    {
        Task<ApiResponse<List<AllReelsInBrandRes>>> GetReelsByBrandAsync(int brandId, string? sortBy, string? userId = null);
        Task<ApiResponse<ReelFeedRes>> GetReelByIdAsync(int reelId, string? userId = null);
        Task<ApiResponse<string>> TrackReelViewAsync(string userId, ReelViewReq req);
        Task<ApiResponse<bool>> ToggleReelLikeAsync(string userId, int reelId);
        Task<ApiResponse<int>> TrackReelShareAsync(string userId, int reelId);
    }
}
