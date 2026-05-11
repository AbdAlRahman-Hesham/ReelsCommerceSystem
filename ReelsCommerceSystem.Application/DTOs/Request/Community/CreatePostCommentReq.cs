using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Community
{
    public class CreatePostCommentReq
    {
        public int PostId { get; set; }

        public string Content { get; set; } = string.Empty;

        // null => main comment
        // value => reply
        public int? ParentCommentId { get; set; }
    }
}
