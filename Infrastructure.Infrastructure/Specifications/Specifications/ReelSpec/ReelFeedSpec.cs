using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
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
        //fyp
        public ReelFeedSpec() : base(orderBy: r => r.CreatedAt,
        sortOrder: XmlSortOrder.Descending)
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.ReelComments);

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
        public ReelFeedSpec(int pageIndex, int pageSize) : base(orderBy: r => r.CreatedAt,
        sortOrder: XmlSortOrder.Descending)
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.ReelComments);

            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Reviews)
            );
            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Images));
            ApplyPaging(pageIndex, pageSize);
        }
        //following
        public ReelFeedSpec(List<int> followedBrandIds) : base(criteria:
            r => followedBrandIds.Contains(r.BrandId))
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.ReelComments);

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
        public ReelFeedSpec(List<int> followedBrandIds, int pageIndex, int pageSize) : base(criteria:
            r=>followedBrandIds.Contains(r.BrandId))
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.ReelComments);

            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Reviews)
            );
            AddIncludeChain(q =>
                q.Include(r => r.ProductReels)
                 .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Images));
            ApplyPaging(pageIndex, pageSize);

        }

        // filterByReelId parameter disambiguates from the followedBrandIds constructor
        public ReelFeedSpec(List<int> reelIds, bool filterByReelId) : base(criteria:
            r => reelIds.Contains(r.Id))
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.ReelComments);

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


    }
}

