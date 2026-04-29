using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec
{
    public class MessageCountSpec : Specification<Message>
    {
        public MessageCountSpec(int roomId)
       : base(m => m.RoomId == roomId)
        {
        }
    }
}
