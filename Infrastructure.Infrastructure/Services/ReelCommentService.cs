using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.ReelComment;
using ReelsCommerceSystem.Application.DTOs.Response.ReelComment;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
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

        public async Task<ApiResponse<ReelCommentRes>> AddCommentAsync(AddReelCommentReq dto, string userId)
        {
            try
            {

                var reelRepo = _unitOfWork.Repository<Reel>();
                var commentRepo = _unitOfWork.Repository<ReelComment>();

                // Basic validation if you don't use FluentValidation
                if (string.IsNullOrWhiteSpace(dto.Content))
                {
                    return ApiResponse<ReelCommentRes>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Comment cannot be empty",
                        "لا يمكن إرسال تعليق فارغ"
                    );
                }


                var reel = await reelRepo.GetByIdAsync(dto.ReelId);
                if (reel == null)
                {
                    return ApiResponse<ReelCommentRes>.ErrorResponse(
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

                var response = new ReelCommentRes
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    UserId = comment.UserId,
                    UserName = user.UserName,
                    CreatedAt = comment.CreatedAt
                };

                return ApiResponse<ReelCommentRes>.SuccessResponse(
                    response,
                    HttpStatusCode.Created,
                    "Comment added successfully",
                    "تم إضافة التعليق بنجاح"
                );
            }
            catch (Exception)
            {
                return ApiResponse<ReelCommentRes>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }
    }
    }
