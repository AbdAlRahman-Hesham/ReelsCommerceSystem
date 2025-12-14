using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelCommentReplySpec
{
    public class CountRepliesSpec : Specification<ReelCommentReply>
    {
        public CountRepliesSpec(int parentCommentId)
             : base(r => r.ParentCommentId == parentCommentId)
        {
        }
    }
}
