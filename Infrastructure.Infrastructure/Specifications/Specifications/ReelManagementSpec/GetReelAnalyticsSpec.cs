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
    public class GetReelAnalyticsSpec : Specification<Reel>
    {
        public GetReelAnalyticsSpec(int reelId):
            base(r=>r.Id ==reelId)
        {
            AddInclude(r => r.Brand);

            AddInclude(r => r.UserReelViews);



            
        }
    }
}
