using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Community
{
    public class ToggleCommentLikeRes
    {
        public bool IsLiked { get; set; }

        public int LikesCount { get; set; }
    }
}
