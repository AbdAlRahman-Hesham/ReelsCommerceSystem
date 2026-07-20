using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class GetFollowersOfBrandSpec:Specification<UserBrandFollow>
    {
        public GetFollowersOfBrandSpec(int brandId)
        {
            AddCriteria(f => f.BrandId == brandId);
        }
    }
}
