using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReelCommentService
    {
        Task<ApiResponse<AddReelCommentRes>> AddCommentAsync(AddReelCommentReq dto, string userId);

        Task<ApiResponse<PaginationResponse<ReelCommentRes>>> GetReelCommentsAsync(
        int reelId,
        int pageNumber,
        int pageSize,
        string currentUserId);

    }

}
