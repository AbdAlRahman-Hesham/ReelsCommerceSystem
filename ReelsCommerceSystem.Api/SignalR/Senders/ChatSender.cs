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
        public async Task SendMessage(string roomId, string recipientId, object message)
        {
            // Send to group (for users currently IN the room)
            await _hub.Clients.Group(roomId).SendAsync("OnReceiveMessage", message);
            
            // Send to recipient directly (for unread count/background notification)
            await _hub.Clients.Group(recipientId).SendAsync("OnReceiveMessage", message);
        }

        public async Task MessageSeen(string roomId, string recipientId, List<string> plainMessageIds)
        {
            await _hub.Clients.Group(roomId).SendAsync("OnMessageSeen", plainMessageIds);
            await _hub.Clients.Group(recipientId).SendAsync("OnMessageSeen", plainMessageIds);
        }

        public async Task MessageDelivered(string roomId, string recipientId, List<string> plainMessageIds)
        {
            await _hub.Clients.Group(roomId).SendAsync("OnMessageDelivered", plainMessageIds);
            await _hub.Clients.Group(recipientId).SendAsync("OnMessageDelivered", plainMessageIds);
        }

        public async Task RoomCreated(string userId, object room)
        {
            await _hub.Clients.Group(userId).SendAsync("OnRoomCreated", room);
        }

        public async Task MessageDeleted(string roomId, string recipientId, string plainMessageId)
        {
            await _hub.Clients.Group(roomId).SendAsync("OnMessageDeleted", plainMessageId);
            await _hub.Clients.Group(recipientId).SendAsync("OnMessageDeleted", plainMessageId);
        }

        public async Task RoomDeleted(string roomId, string recipientId)
        {
            // Notify both users via their personal groups
            // The room ID group might be empty if they disconnect, so user groups are safer for sidebar updates
            await _hub.Clients.Group(recipientId).SendAsync("OnRoomDeleted", roomId);
            
            // Note: We don't usually need to notify the deleter since their UI already knows,
            // but we do it for multi-tab synchronization.
            var deleterId = _hub.GetType().Name; // Placeholder, usually we'd pass it or get from context
            // Actually, just sending to the roomId group is also good if they are currently IN the room
            await _hub.Clients.Group(roomId).SendAsync("OnRoomDeleted", roomId);
        }

    }
}
