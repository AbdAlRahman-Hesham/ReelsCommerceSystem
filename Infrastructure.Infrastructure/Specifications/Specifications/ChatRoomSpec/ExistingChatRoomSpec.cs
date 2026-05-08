using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ChatRoomSpec
{
    public class ExistingChatRoomSpec :Specification<ChatRoom>
    {
        public ExistingChatRoomSpec(string user1, string user2)
        : base(r =>
            (r.User1Id == user1 && r.User2Id == user2) ||
            (r.User1Id == user2 && r.User2Id == user1))
        {
        }
    }
}
