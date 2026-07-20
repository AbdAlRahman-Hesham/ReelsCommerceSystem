using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class BrandReviewByUserSpec :Specification<BrandReview>
    {
        public BrandReviewByUserSpec(int brandId, string userId)
            : base(r => r.BrandId == brandId && r.UserId == userId)
        {
            
        }
    }
}
