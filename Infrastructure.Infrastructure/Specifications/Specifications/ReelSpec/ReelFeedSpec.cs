using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec
{
    public class ReelFeedSpec : Specification<Reel>
    {
        private void AddCommonIncludes()
        {
            AddInclude(r => r.Brand);
            AddInclude(r => r.ReelComments);
            AddInclude(r => r.UserReelLikes);
            AddInclude(r => r.UserReelViews);

            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Reviews)

            );
            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Images));
        }

        public ReelFeedSpec() : base(criteria: r => r.Status == ReelStatus.Published,
        orderBy: r => r.CreatedAt,
        sortOrder: XmlSortOrder.Descending)
        {
            AddCommonIncludes();
        }
        public ReelFeedSpec(int pageIndex, int pageSize) : base(criteria: r => r.Status == ReelStatus.Published,
        orderBy: r => r.CreatedAt,
        sortOrder: XmlSortOrder.Descending)
        {
            AddCommonIncludes();
            ApplyPaging(pageIndex, pageSize);
        }

        public ReelFeedSpec(List<int> followedBrandIds) : base(criteria:
            r => followedBrandIds.Contains(r.BrandId) && r.Status == ReelStatus.Published)
        {
            AddCommonIncludes();
        }
        public ReelFeedSpec(List<int> followedBrandIds, int pageIndex, int pageSize) : base(criteria:
            r => followedBrandIds.Contains(r.BrandId) && r.Status == ReelStatus.Published)
        {
            AddCommonIncludes();
            ApplyPaging(pageIndex, pageSize);
        }

        public ReelFeedSpec(List<int> reelIds, bool filterByReelId) : base(criteria:
            r => reelIds.Contains(r.Id) && r.Status == ReelStatus.Published)
        {
            AddCommonIncludes();
        }


    }
}

