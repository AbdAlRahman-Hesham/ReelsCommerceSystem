using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentSpec
{
    public class CountCommentsSpec : Specification<ReelComment>
    {
        public CountCommentsSpec(int reelId)
            : base(c => c.ReelId == reelId)
        {
        }

    }

    
}
