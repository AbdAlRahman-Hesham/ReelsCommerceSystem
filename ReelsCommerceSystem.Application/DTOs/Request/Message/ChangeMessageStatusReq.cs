using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Message
{
    public class ChangeMessageStatusReq
    {
        public string RoomId { get; set; } = default!;
        public string Status { get; set; } = default!;
        public List<string> MessageIdsEncrypted { get; set; } = new();
    }
}
