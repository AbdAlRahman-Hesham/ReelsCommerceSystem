using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ChatRoom
{
    public class ChatRoomRes
    {
        public string RoomIdEnc { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserImageUrl { get; set; } = null!;
        public int UnreadCount { get; set; }
        public string? LastMessage { get; set; }
        public DateTime? LastMessageAt { get; set; }
    }
}
