using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentReplySpec
{
    public class GetRepliesSpec : Specification<ReelCommentReply>
    {
        public GetRepliesSpec(int parentCommentId, int pageIndex, int pageSize)
         : base(r => r.ParentCommentId == parentCommentId)
        {
            AddInclude(r => r.User);
            AddInclude(r => r.Loves);

            AddOrderByDescending(r => r.CreatedAt);

            ApplyPaging(pageIndex, pageSize);
        }
    }
}
