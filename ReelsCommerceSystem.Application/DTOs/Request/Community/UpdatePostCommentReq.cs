using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Community
{
    public class UpdatePostCommentReq
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = string.Empty;

    }
}
