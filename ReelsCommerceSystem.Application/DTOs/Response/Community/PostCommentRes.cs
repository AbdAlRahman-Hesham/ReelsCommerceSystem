using ReelsCommerceSystem.Application.DTOs.Response.PagedResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Community
{
    public class PostCommentRes
    {
        public int CommentId { get; set; }

        public string BrandName { get; set; } = string.Empty;

        public string BrandOwnerName { get; set; } = string.Empty;

        public string BrandLogoUrl { get; set; } = string.Empty;

        public string BrandOwnerImageUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public string Content { get; set; } = string.Empty;

        public int LikesCount { get; set; }

        public int RepliesCount { get; set; }

        public bool Isliked { get; set; }

        public List<PostCommentRes> Replies { get; set; } = [];
    }
}
