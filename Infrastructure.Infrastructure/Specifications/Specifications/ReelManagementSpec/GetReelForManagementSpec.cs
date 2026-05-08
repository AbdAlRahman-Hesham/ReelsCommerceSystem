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
    public class GetReelForManagementSpec : Specification<Reel>
    {
        public GetReelForManagementSpec(int reelId) :
            base(r=>r.Id==reelId)
        {
            AddInclude(r => r.Brand);

            AddIncludeChain(query => query.
            Include(r => r.UserReelLikes));

            AddIncludeChain(query => query.
            Include(r => r.ReelComments).
            ThenInclude(cr=>cr.User));

            AddIncludeChain(query => query.
            Include(r => r.ReelComments).
            ThenInclude(cr => cr.Loves));

            AddIncludeChain(query => query.
            Include(r => r.ProductReels).
            ThenInclude(pr => pr.Product).
            ThenInclude(p=>p.Images));

        }
    }
}
