using ReelsCommerceSystem.Application.DTOs.Response.PagedResponse;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Community
{
    public class GetCommunityPostsRes :PagedResponse<PostInCommunityPostsRes>
    {
        public CommunityPostsCountsRes Counts { get; set; } = new();

    }

    public class PostInCommunityPostsRes
    {
        public int PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string BrandOwnerName { get; set; } = string.Empty;
        public string BrandLogoUrl { get; set; } = string.Empty;
    }
}
