using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelComment
{
    public class ReelCommentRes
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public int CommentLikeCount { get; set; }
        public bool IsLovedByCurrentUser { get; set; }
        public DateTime CreatedAt { get; set; }

        public int RepliesCount { get; set; }
    }
}
