using MailKit.Search;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec
{
    internal class ReelsByBrandWithSortingSpec : Specification<Reel>
    {
        public ReelsByBrandWithSortingSpec(int brandId, string? SortBy = null)
            : base(criteria: r => r.BrandId == brandId,
                   includes: [r => r.Product])
        {
            {

                if (SortBy == "oldest")
                    AddOrderBy(r => r.CreatedAt);
                else if (SortBy == "popular")
                    AddOrderByDescending(r => r.NumOfLikes);
            }
        }
    }
}
