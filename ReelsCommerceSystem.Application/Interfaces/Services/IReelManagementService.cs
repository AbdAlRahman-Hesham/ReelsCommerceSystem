using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReelManagementService
    {
        public Task<GetBrandReelsRes> GetBrandReelsAsync(GetBrandReelsReq req,string userId);
        public Task<GetProductsForBrandRes> GetProductsForBrandAsync(GetProductsForBrandReq req, string userId);
        public Task<CreateReelRes> CreateReelAsync(CreateReelReq req, string userId);
        public Task<EditReelRes> EditReelAsync(EditReelReq req, string userId);
        public Task<GetReelForManagementRes> GetReelAsync(int reelId, string userId);
        public Task<GetReelAnalyticsRes> GetReelAnalyticsAsync(int reelId, int year, string userId);
        public Task<bool> DeleteReelAsync(int reelId, string userId);



    }
}
