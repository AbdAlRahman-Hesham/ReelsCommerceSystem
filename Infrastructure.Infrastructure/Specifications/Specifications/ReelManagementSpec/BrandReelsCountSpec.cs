using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec
{
    public class BrandReelsCountSpec : Specification<Reel>
    {
        public BrandReelsCountSpec(int brandId)
            : base(criteria: b => b.BrandId == brandId)
        {

        }

    }
}
