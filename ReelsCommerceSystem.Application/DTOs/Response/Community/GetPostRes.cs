using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Community
{
    public class GetPostRes
    {
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public bool CommentsEnabled { get; set; }
        public DateTime CreatedAt { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string BrandOwnerName { get; set; } = string.Empty;
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public bool IsLiked { get; set; }
        public bool IsByMe { get; set; }

    }

}
