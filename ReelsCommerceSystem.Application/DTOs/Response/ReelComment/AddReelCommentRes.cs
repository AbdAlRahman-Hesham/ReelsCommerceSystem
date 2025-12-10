using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelComment
{
    public class AddReelCommentRes
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
