using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Interest;
using ReelsCommerceSystem.Application.DTOs.Response.Interest;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class InterestService : IInterestService
    {
        private readonly AppDbContext _dbContext;

        public InterestService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserInterestResDto>> GetAllInterestsAsync()
        {
            var interests = await _dbContext.Interests.ToListAsync();
            var InterestsList = interests.Select(i => new UserInterestResDto
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();

            return InterestsList;
        }

        public async Task<ApiResponse<UserInterestResultDto>> SaveUserInterestsAsync(string userId, UserInterestSaveRequestDto request)
        {
            if (string.IsNullOrEmpty(userId))
                return ApiResponse<UserInterestResultDto>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Token is invalid or expired.",
                    "التوكن غير صالح أو منتهي الصلاحية.");

            if (request?.InterestIds == null || !request.InterestIds.Any())
            {
                var errors = new List<ValidationError>
                {
                    new ValidationError { Field = "interestIds", En = "No interest IDs provided.", Ar = "لم يتم إرسال أي معرفات للاهتمامات." }
                };

                return ApiResponse<UserInterestResultDto>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "No interest IDs provided.",
                    "لم يتم إرسال أي معرفات للاهتمامات.",
                    errors);
            }

            var distinctRequestedIds = request.InterestIds.Distinct().ToList();

            var validIds = await _dbContext.Interests
                .Where(i => distinctRequestedIds.Contains(i.Id))
                .Select(i => i.Id)
                .ToListAsync();

            if (validIds.Count != distinctRequestedIds.Count)
            {
                var errors = new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "interestIds",
                        En = "One or more IDs do not exist.",
                        Ar = "أحد أو أكثر من المعرفات غير موجودة."
                    }
                };

                return ApiResponse<UserInterestResultDto>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Invalid interest IDs provided.",
                    "تم إدخال معرفات اهتمامات غير صالحة.",
                    errors);
            }

            var existing = _dbContext.UserInterests.Where(ui => ui.UserId == userId);
            _dbContext.UserInterests.RemoveRange(existing);

            var newRelations = distinctRequestedIds
                .Select(id => new UserInterest
                {
                    UserId = userId,
                    InterestId = id
                })
                .ToList();

            if (newRelations.Any())
                await _dbContext.UserInterests.AddRangeAsync(newRelations);

            await _dbContext.SaveChangesAsync();

            var result = new UserInterestResultDto
            {
                UserId = userId,
                SelectedInterests = newRelations.Select(n => n.InterestId).ToList()
            };

            return ApiResponse<UserInterestResultDto>.SuccessResponse(
                result,
                HttpStatusCode.OK,
                "User interests saved successfully.",
                "تم حفظ اهتمامات المستخدم بنجاح.");
        }
    }
}

