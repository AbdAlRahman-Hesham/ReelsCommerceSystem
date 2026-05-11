using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Community
{
    public class CreatePostReq
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public IFormFile CoverImage { get; set; } = null!;
        public string? Status { get; set; } = PostStatus.Draft.ToString().ToLower();
        public bool CommentsEnabled { get; set; } = true;

    }
}
