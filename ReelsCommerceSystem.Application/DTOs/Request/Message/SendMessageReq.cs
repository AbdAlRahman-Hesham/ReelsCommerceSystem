using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Message
{
    public class SendMessageReq
    {
        public string RoomId { get; set; }     // encrypted
        public string? Text { get; set; }      // encrypted
        public string? ImageUrl { get; set; }  
    }
}
