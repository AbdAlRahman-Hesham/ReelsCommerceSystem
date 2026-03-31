using ReelsCommerceSystem.Application.DTOs.Response.RejectionReason;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.RejectionReasonSpec;
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
    public class RejectionReasonService : IRejectionReasonService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RejectionReasonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }


        public async Task<ApiResponse<IReadOnlyList<RejectionReasonRes>>> GetAllAsync()
        {
            var spec = new GetAllRejectionReasonsSpec();

            var reasons = await _unitOfWork
                .Repository<RejectionReason>()
                .GetAllWithSpecAsync(spec);

            var result = reasons.Select(r => new RejectionReasonRes
            {
                id = r.Id,
                Code = r.Code,
                Description =  r.Description,
            }).ToList();

            return ApiResponse<IReadOnlyList<RejectionReasonRes>>
                .SuccessResponse(result, HttpStatusCode.OK);
        }

    }
}
