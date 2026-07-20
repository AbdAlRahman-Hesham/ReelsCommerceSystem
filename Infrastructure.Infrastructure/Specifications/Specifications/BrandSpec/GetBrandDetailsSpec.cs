using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class GetBrandDetailsSpec : Specification<Brand>
    {
        public GetBrandDetailsSpec(int id)
            : base(b => b.Id == id)
        {
            Includes.Add(b => b.user);
            Includes.Add(b => b.BrandVerification);
            Includes.Add(b => b.RejectionReason);
        }
    }
}
