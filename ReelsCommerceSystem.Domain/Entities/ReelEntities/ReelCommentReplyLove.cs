using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities
{
    public class ReelCommentReplyLove : BaseEntity
    {
        public int ReelCommentReplyId { get; set; }
        public ReelCommentReply ReelCommentReply { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
