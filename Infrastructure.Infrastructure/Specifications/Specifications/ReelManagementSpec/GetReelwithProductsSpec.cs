using FluentValidation.Validators;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec
{
    public class GetReelwithProductsSpec : Specification<Reel>
    {
        public GetReelwithProductsSpec(int reelId):
            base(criteria: r=>r.Id==reelId)
        {
            AddIncludeChain(query => query.Include(r => r.Brand)
            .ThenInclude(b => b.user));

            AddIncludeChain(query => query.Include(r => r.ProductReels)
            .ThenInclude(pr=>pr.Product));

            AddIncludeChain(query => query.Include(r => r.ReelComments));

            AddInclude(r => r.UserReelLikes);

            AddInclude(r => r.ProductReels);
        }

    }
}
