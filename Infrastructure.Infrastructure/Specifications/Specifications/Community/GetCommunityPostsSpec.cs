using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Community
{
    public class GetCommunityPostsSpec : Specification<CommunityPost>
    {
        public GetCommunityPostsSpec(GetCommunityPostsReq req, int brandId)
            : base(p =>

                (string.IsNullOrEmpty(req.Search) ||
                 p.Title.Contains(req.Search))

                &&

                (
                    // published only
                    (req.Status == "published" &&
                     p.Status == PostStatus.Published)

                    ||

                    // my drafts only
                    (req.Status == "draft" &&
                     p.Status == PostStatus.Draft &&
                     p.BrandId == brandId)

                    ||

                    // all:
                    // all published posts + my drafts
                    (req.Status == "all" &&
                     (
                        p.Status == PostStatus.Published
                        ||
                        (p.Status == PostStatus.Draft &&
                         p.BrandId == brandId)
                     ))
                )
            )
        {
            if (req.Sort == "oldest")
                AddOrderBy(p => p.CreatedAt);
            else
                AddOrderByDescending(p => p.CreatedAt);

            AddIncludeChain(query =>
                query.Include(p => p.Brand)
                     .ThenInclude(b => b.user));

            ApplyPaging(req.PageIndex, req.PageSize);
        }
    }
}
