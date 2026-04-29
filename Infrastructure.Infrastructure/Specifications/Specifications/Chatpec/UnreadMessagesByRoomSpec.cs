using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec
{
    public class UnreadMessagesByRoomSpec : Specification<Message>
    {
        public UnreadMessagesByRoomSpec(int roomId, string recipientId, MessageStatus status)
             : base(criteria: m => m.RoomId == roomId && m.SenderId != recipientId && m.Status < status)
        {
        }
    }
}
