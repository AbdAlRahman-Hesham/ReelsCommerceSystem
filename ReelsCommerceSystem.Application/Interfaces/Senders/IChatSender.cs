using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Senders
{
    public interface IChatSender
    {
        Task SendMessage(string roomId, object message);
        Task MessageSeen(string roomId, object messageIds);
        Task MessageDelivered(string roomId, object messageIds);
    }
}
