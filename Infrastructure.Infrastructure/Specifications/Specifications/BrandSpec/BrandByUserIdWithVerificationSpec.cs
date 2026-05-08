using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class BrandByUserIdWithVerificationSpec : Specification<Brand>
    {
        public BrandByUserIdWithVerificationSpec(string userId)
            : base(b => b.UserId == userId)
        {
            Includes.Add(b => b.BrandVerification);
            Includes.Add(b => b.user);
        }

    }
}
