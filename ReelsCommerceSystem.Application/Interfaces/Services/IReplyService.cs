using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Request.Reply;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Response.ReelCommentReply;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReplyService
    {
        Task<ApiResponse<PaginationResponse<DTOs.Response.ReelComment.ReelCommentReplyRes>>> GetRepliesAsync(
            int parentCommentId, 
            int pageNumber, 
            int pageSize,
            string cuurentuserId);


        Task<ApiResponse<AddReelCommentReplyRes>> AddRepliesAsync(AddReplyReq dto, string userId);

        Task<ApiResponse<bool>> ToggleReplyLikeAsync(int replyId, string userId);
    }
}
