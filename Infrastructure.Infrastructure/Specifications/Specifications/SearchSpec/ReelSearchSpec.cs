using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.SearchSpec
{
    public class ReelSearchSpec:Specification<Reel>
    {
        public ReelSearchSpec(string searchText, int pageIndex, int pageSize)
         : base(criteria:( r => string.IsNullOrEmpty(searchText) ||
                     r.Title.Contains(searchText)))
        {
            AddInclude(r => r.ProductReels);
            AddInclude(r => r.UserReelLikes);
            AddInclude("ProductReels.Product");

            AddOrderByDescending(r => r.CreatedAt);

            ApplyPaging(pageIndex, pageSize);
        }
        public ReelSearchSpec(string searchText)
         : base(criteria: (r => string.IsNullOrEmpty(searchText) ||
                     r.Title.Contains(searchText)))
        {
            AddInclude(r => r.ProductReels);
            AddInclude(r => r.UserReelLikes);
            AddInclude("ProductReels.Product");

            AddOrderByDescending(r => r.CreatedAt);
        }
    }
}
