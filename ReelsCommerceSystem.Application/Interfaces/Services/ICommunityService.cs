using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ICommunityService
    {
        //POST
        public Task<CreatePostRes> CreatePostAsync(CreatePostReq req, string userId);
        public Task<GetPostRes> GetPostAsync(int postId, string userId);
        public Task<GetCommunityPostsRes> GetPostsAsync(GetCommunityPostsReq req, string userId);
        public Task<EditPostRes> EditPostAsync(EditPostReq req, string userId);
        public Task<bool> DeletePostAsync(int postId, string userId);
        Task<TogglePostLikeRes> TogglePostLikeAsync(int postId,string userId);
    }
}
