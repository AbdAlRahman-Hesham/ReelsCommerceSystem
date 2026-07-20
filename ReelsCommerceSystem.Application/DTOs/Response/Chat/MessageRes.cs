using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Chat
{
    public class MessageRes
    {
        public string MessageIdEncr { get; set; }   // encrypted
        public string RoomIdEncr { get; set; }      // encrypted
        public string SenderIdEncr { get; set; }    // encrypted
        public string? TextEncr { get; set; }       // encrypted
        public string? ImageUrlEncr { get; set; }   // plain
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
