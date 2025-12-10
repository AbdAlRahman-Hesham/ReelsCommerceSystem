using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentSpec
{
    public class GetCommentsSpec : Specification<ReelComment>
    {
        public GetCommentsSpec(int reelId, int pageIndex, int pageSize)
       : base(c=>c.ReelId == reelId)
        {
            AddInclude(c => c.User);
            AddInclude(c => c.Loves);
            AddInclude(c => c.Replies);
            AddInclude("Replies.User");
            AddInclude("Replies.Loves");

            AddOrderByDescending(c => c.CreatedAt);

            ApplyPaging(pageIndex, pageSize);
        }
    }
}
