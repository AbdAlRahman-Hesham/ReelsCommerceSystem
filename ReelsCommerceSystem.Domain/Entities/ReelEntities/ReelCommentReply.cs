using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities
{
    public class ReelCommentReply : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        // Parent comment
        public int ParentCommentId { get; set; }
        public ReelComment ParentComment { get; set; } = null!;

        // Author
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

 
        public ICollection<ReelCommentReplyLove> Loves { get; set; } = new List<ReelCommentReplyLove>();
    }
}
