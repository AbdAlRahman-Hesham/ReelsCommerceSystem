using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Api.SignalR.Hubs;
using ReelsCommerceSystem.Application.Interfaces.Senders;

namespace ReelsCommerceSystem.Api.SignalR.Senders
{
    public class NotificationRealtimeSender : INotificationRealtimeSender
    {
        private readonly IHubContext<NotificationHub> _hub;

        public NotificationRealtimeSender(IHubContext<NotificationHub> hub)
        {
            _hub = hub;
        }

        public async Task SendNotificationToUsersAsync(List<string> userIds, object notification)
        {
            await _hub.Clients.Groups(userIds)
                .SendAsync("ReceiveNotification", notification);
        }

        public async Task UpdateUnreadCountAsync(string userId, int count)
        {
            await _hub.Clients.Group(userId)
                 .SendAsync("UpdateUnreadCount", count);
        }
    }
}
