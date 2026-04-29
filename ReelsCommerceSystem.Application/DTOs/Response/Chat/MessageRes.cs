using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Chat
{
    public class MessageRes
    {
        public string MessageId { get; set; }   // encrypted
        public string RoomId { get; set; }      // encrypted
        public string? Text { get; set; }       // encrypted
        public string? ImageUrl { get; set; }   // plain
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
