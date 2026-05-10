using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec
{
    public class GetBrandReelsSpec : Specification<Reel>
    {
        public GetBrandReelsSpec(GetBrandReelsReq request)
        : base(r =>
            r.BrandId == request.BrandId &&
            (request.Status == "all" || r.Status == Enum.Parse<ReelStatus>(request.Status, true)) &&
            (string.IsNullOrEmpty(request.Search) || r.Title.Contains(request.Search))
        )
        {
            if (request.Sort== "oldest")
                AddOrderBy(r => r.CreatedAt);
            else
                AddOrderByDescending(r => r.CreatedAt);

            AddIncludeChain(query =>
            query.Include(r => r.Brand)
            .ThenInclude(b => b.user));

            AddIncludeChain(query =>
            query.Include(r => r.ProductReels)
            .ThenInclude(Pr => Pr.Product));

            AddInclude(r => r.ReelComments);
            AddInclude(r => r.ProductReels);
            AddInclude(r => r.UserReelLikes);


            ApplyPaging(request.PageIndex,request.PageSize);
        }
    }
}
