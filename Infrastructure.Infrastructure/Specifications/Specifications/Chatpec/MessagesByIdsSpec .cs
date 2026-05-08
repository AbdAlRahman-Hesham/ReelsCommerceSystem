using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec
{
    public class MessagesByIdsSpec : Specification<Message>
    {
        public MessagesByIdsSpec(List<int> ids, int roomId)
        : base(m => ids.Contains(m.Id) && m.RoomId == roomId)
        {
        }
    }
}
