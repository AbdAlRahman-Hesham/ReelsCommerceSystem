using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Community
{
    public class EditPostReq
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public IFormFile? CoverImage { get; set; }
        public string? Status { get; set; } 
        public bool? CommentsEnabled { get; set; }

    }
}
