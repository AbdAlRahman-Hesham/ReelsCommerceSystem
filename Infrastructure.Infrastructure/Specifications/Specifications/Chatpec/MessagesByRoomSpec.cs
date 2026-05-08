using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec
{
    public class MessagesByRoomSpec: Specification<Message>
    {
        public MessagesByRoomSpec(int roomId)
             : base(criteria: m => m.RoomId == roomId)
        {
        }
    }
}
