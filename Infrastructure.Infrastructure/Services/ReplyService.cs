using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.Reply;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Response.ReelCommentReply;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentReplySpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReplyService : IReplyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public ReplyService(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<ApiResponse<PaginationResponse<Application.DTOs.Response.ReelComment.ReelCommentReplyRes>>> GetRepliesAsync(int parentCommentId, int pageNumber, int pageSize, string currentUserId)
        {
            var spec = new GetRepliesSpec(parentCommentId, pageNumber, pageSize);

            var replies = await _unitOfWork.Repository<ReelCommentReply>().GetAllWithSpecAsync(spec);

            if (replies == null)
            {
                return ApiResponse<PaginationResponse<Application.DTOs.Response.ReelComment.ReelCommentReplyRes>>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    en: "Reel not found.",
                    ar: "الريل غير موجود."
                );

            }

            var countSpec = new CountRepliesSpec(parentCommentId);
            var totalCount = await _unitOfWork.Repository<ReelCommentReply>().CountAsync(countSpec);


            var mappedReplies = replies.Select(r => new Application.DTOs.Response.ReelComment.ReelCommentReplyRes
            {
                Id = r.Id,
                Content = r.Content,
                UserName = r.User.UserName,
                UserImage = r.User.ImageURL,
                LikeCount = r.Loves.Count(),
                IsLovedByCurrentUser = r.Loves.Any(l => l.UserId == currentUserId),
                CreatedAt = r.CreatedAt

            }).ToList();



            var meta = new Meta
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalCount,
                HasPreviousPage = pageNumber > 1,
                HasNextPage = pageNumber * pageSize < totalCount
            };


            return PaginationResponse<Application.DTOs.Response.ReelComment.ReelCommentReplyRes>.SuccessResponse(
                 mappedReplies,
                 meta,
                 HttpStatusCode.OK
             );


        }

        public async Task<ApiResponse<AddReelCommentReplyRes>> AddRepliesAsync(AddReplyReq dto, string userId)
        {
            try
            {
                var replyRepo = _unitOfWork.Repository<ReelCommentReply>();
                var commentRepo = _unitOfWork.Repository<ReelComment>();

                if (string.IsNullOrWhiteSpace(dto.Content))
                {
                    return ApiResponse<AddReelCommentReplyRes>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Comment cannot be empty",
                        "لا يمكن إرسال تعليق فارغ"
                    );
                }

                var comment = await commentRepo.GetByIdAsync(dto.CommentId);
                if (comment == null)
                {
                    return ApiResponse<AddReelCommentReplyRes>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "comment not found",
                        "التعليق غير موجود"
                    );
                }

                // ⭐ Load user from UserManager
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return ApiResponse<AddReelCommentReplyRes>.ErrorResponse(
                        HttpStatusCode.Unauthorized,
                        "User not found",
                        "المستخدم غير موجود"
                    );
                }

                var reply = new ReelCommentReply
                {
                    Content = dto.Content,
                    ParentCommentId = dto.CommentId,
                    CreatedAt = DateTime.UtcNow,
                    UserId = userId
                };

                await replyRepo.AddAsync(reply);
                await _unitOfWork.SaveChangesAsync();

                var response = new AddReelCommentReplyRes
                {
                    Id = reply.Id,
                    Content = reply.Content,
                    UserId = userId,
                    UserName = user.UserName!,
                    CreatedAt = reply.CreatedAt
                };

                return ApiResponse<AddReelCommentReplyRes>.SuccessResponse(
                   response,
                   HttpStatusCode.Created,
                   "Reply added successfully",
                   "تم إضافة الرد بنجاح"
               );
            }
            catch (Exception)
            {
                return ApiResponse<AddReelCommentReplyRes>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }

        public async Task<ApiResponse<bool>> ToggleReplyLikeAsync(int replyId, string userId)
        {
            var replyRepo = _unitOfWork.Repository<ReelCommentReply>();
            var loveRepo = _unitOfWork.Repository<ReelCommentReplyLove>();

            // Check reply exists
            var reply = await replyRepo.GetByIdAsync(replyId);
            if (reply == null)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Reply not found",
                    "الرد غير موجود"
                );
            }

            // Check if user already liked this reply
            var spec = new Specification<ReelCommentReplyLove>(
                    criteria: like => like.UserId == userId && like.ReelCommentReplyId == replyId
                );

            var existingLike = await loveRepo.GetWithSpecAsync(spec);

            bool isLiked;
            if (existingLike != null)
            {
                // Unlike → remove record
                loveRepo.Delete(existingLike);
                isLiked = false;
            }
            else
            {
                // Like → add record
                var newLike = new ReelCommentReplyLove
                {
                    ReelCommentReplyId = replyId,
                    UserId = userId
                };

                await loveRepo.AddAsync(newLike);
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

    }
}

