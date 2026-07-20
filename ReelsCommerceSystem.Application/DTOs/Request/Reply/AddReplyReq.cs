using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Reply
{
    public class AddReplyReq
    {
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage = "Reel Id is required")]
        public int CommentId { get; set; }
    }
}
