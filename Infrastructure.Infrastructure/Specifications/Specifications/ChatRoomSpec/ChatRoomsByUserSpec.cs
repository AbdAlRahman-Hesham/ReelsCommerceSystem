using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ChatRoomSpec
{
    public class ChatRoomsByUserSpec : Specification<ChatRoom>
    {
        public ChatRoomsByUserSpec(string userId)
        : base(r => r.User1Id == userId || r.User2Id == userId)
        {
            AddInclude(r => r.Messages);
        }
    }
}
