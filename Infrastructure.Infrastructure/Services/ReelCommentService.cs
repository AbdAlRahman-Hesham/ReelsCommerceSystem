using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReelCommentService : IReelCommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public ReelCommentService(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<ApiResponse<AddReelCommentRes>> AddCommentAsync(AddReelCommentReq dto, string userId)
        {
            try
            {

                var reelRepo = _unitOfWork.Repository<Reel>();
                var commentRepo = _unitOfWork.Repository<ReelComment>();

                if (string.IsNullOrWhiteSpace(dto.Content))
                {
                    return ApiResponse<AddReelCommentRes>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Comment cannot be empty",
                        "لا يمكن إرسال تعليق فارغ"
                    );
                }


                var reel = await reelRepo.GetByIdAsync(dto.ReelId);
                if (reel == null)
                {
                    return ApiResponse<AddReelCommentRes>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "Reel not found",
                        "الرّيل غير موجود"
                    );
                }


                var comment = new ReelComment
                {
                    ReelId = dto.ReelId,
                    Content = dto.Content.Trim(),
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow
                };


                await commentRepo.AddAsync(comment);
                await _unitOfWork.SaveChangesAsync();

                var user = await _userManager.FindByIdAsync(userId);

                var response = new AddReelCommentRes
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    UserId = comment.UserId,
                    UserName = user.DisplayName,
                    CreatedAt = comment.CreatedAt
                };

                return ApiResponse<AddReelCommentRes>.SuccessResponse(
                    response,
                    HttpStatusCode.Created,
                    "Comment added successfully",
                    "تم إضافة التعليق بنجاح"
                );
            }
            catch (Exception)
            {
                return ApiResponse<AddReelCommentRes>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }

        public async Task<ApiResponse<PaginationResponse<ReelCommentRes>>> GetReelCommentsAsync(
       int reelId,
       int pageNumber,
       int pageSize,
       string currentUserId)
        {
            var reelExists = await _unitOfWork.Repository<Reel>()
                .GetByIdAsync(reelId);

            if (reelExists==null)
            {
                return ApiResponse<PaginationResponse<ReelCommentRes>>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    en: "Reel not found.",
                    ar: "الريل غير موجود."
                );
            }

            var commentsSpec = new GetCommentsSpec(reelId, pageNumber, pageSize);
            var countSpec = new CountCommentsSpec(reelId);

            
            var comments = await _unitOfWork.Repository<ReelComment>().GetAllWithSpecAsync(commentsSpec);
            var totalCount = await _unitOfWork.Repository<ReelComment>().CountAsync(countSpec);

            
            var mappedComments = comments.Select(c => new ReelCommentRes
            {
                Id = c.Id,
                Content = c.Content,
                UserName = c.User.DisplayName,
                UserImage = c.User.ImageURL,
                CreatedAt = c.CreatedAt,
                CommentLikeCount = c.Loves.Count,
                IsLovedByCurrentUser = c.Loves.Any(l => l.UserId == currentUserId),
                RepliesCount = c.Replies.Count,
            }).ToList();
               


            var meta = new Meta
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalCount,
                HasPreviousPage = pageNumber > 1,
                HasNextPage = pageNumber * pageSize < totalCount
            };

            return PaginationResponse<ReelCommentRes>.SuccessResponse(
                mappedComments,
                meta,
                HttpStatusCode.OK
            );
        }
        public async Task<ApiResponse<bool>> ToggleCommentLikeAsync(int commentId, string userId)
        {
            try
            {
                var commentRepo = _unitOfWork.Repository<ReelComment>();
                var loveRepo = _unitOfWork.Repository<ReelCommentLove>();

                // Check comment exists
                var comment = await commentRepo.GetByIdAsync(commentId);
                if (comment == null)
                {
                    return ApiResponse<bool>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "Comment not found",
                        "التعليق غير موجود"
                    );
                }

                // Create specification to check existing like
                var spec = new Specification<ReelCommentLove>(
                    criteria: like => like.UserId == userId && like.ReelCommentId == commentId
                );

                var existingLike = await loveRepo.GetWithSpecAsync(spec);

                bool isLiked;

                if (existingLike != null)
                {
                    // Already liked → remove like
                    loveRepo.Delete(existingLike);
                    isLiked = false;
                }
                else
                {
                    // Not liked → add like
                    var newLove = new ReelCommentLove
                    {
                        UserId = userId,
                        ReelCommentId = commentId,
                        CreatedAt = DateTime.UtcNow
                    };

                    await loveRepo.AddAsync(newLove);
                    isLiked = true;
                }

                await _unitOfWork.SaveChangesAsync();

                return ApiResponse<bool>.SuccessResponse(
                    isLiked,
                    HttpStatusCode.OK,
                    "Toggle successful",
                    "تم تنفيذ العملية بنجاح"
                );
            }
            catch (Exception)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }


    }
}
