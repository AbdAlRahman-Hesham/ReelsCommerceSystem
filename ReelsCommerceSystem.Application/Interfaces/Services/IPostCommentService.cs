using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IPostCommentService
    {
        public Task<PostCommentRes> GetCommentByIdAsync(int commentId, string userId);
        public Task<IEnumerable<PostCommentRes>> GetPostCommentsAsync(int postId, string userId);
        public Task<int> CreateCommentAsync(CreatePostCommentReq req, string userId);
        public Task UpdateCommentAsync(UpdatePostCommentReq req, string userId);
        public Task DeleteCommentAsync(int commentId, string userId);
        public Task<ToggleCommentLikeRes> ToggleCommentLikeAsync(int commentId, string userId);
    }
}
