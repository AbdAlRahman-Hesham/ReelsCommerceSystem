using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Api.SignalR.Hubs;
using ReelsCommerceSystem.Application.Interfaces.Senders;

namespace ReelsCommerceSystem.Api.SignalR.Senders
{
    public class ChatSender : IChatSender
    {
        private readonly IHubContext<ChatHub> _hub;
        public ChatSender(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }
        public async Task SendMessage(string roomId, object message)
        {
            await _hub.Clients.Group(roomId)
                .SendAsync("OnReceiveMessage", message);
        }

        public async Task MessageSeen(string roomId, object messageIds)
        {
            await _hub.Clients.Group(roomId)
                .SendAsync("OnMessageSeen", messageIds);
        }

        public async Task MessageDelivered(string roomId, object messageIds)
        {
            await _hub.Clients.Group(roomId)
                .SendAsync("OnMessageDelivered", messageIds);
        }

    }
}
