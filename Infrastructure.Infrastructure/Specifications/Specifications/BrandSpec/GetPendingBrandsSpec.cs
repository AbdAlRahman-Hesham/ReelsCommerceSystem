using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class GetPendingBrandsSpec : Specification<Brand>
    {
        public GetPendingBrandsSpec()
            : base(b => b.Status == BrandStatus.PENDING_APPROVAL)
        {
            Includes.Add(b => b.user);
            Includes.Add(b => b.BrandVerification);
        }
    }
}
