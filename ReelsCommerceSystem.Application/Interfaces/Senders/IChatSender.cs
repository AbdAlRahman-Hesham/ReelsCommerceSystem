using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Senders
{
    public interface IChatSender
    {
        Task SendMessage(string roomId, string recipientId, object message);
        Task MessageSeen(string roomId, string recipientId, List<string> plainMessageIds);
        Task MessageDelivered(string roomId, string recipientId, List<string> plainMessageIds);
        Task RoomCreated(string userId, object room);
        Task MessageDeleted(string roomId, string recipientId, string plainMessageId);
        Task RoomDeleted(string roomId, string recipientId);
    }
}
