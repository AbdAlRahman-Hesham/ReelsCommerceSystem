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
        public string RoomIdEncr { get; set; }     // encrypted
        public string? TextEncr { get; set; }      // encrypted
        public string? ImageUrl { get; set; }  
    }
}
