using Microsoft.AspNetCore.SignalR;

namespace ReelsCommerceSystem.Api.SignalR.Hubs
{
    public class NotificationHub: Hub
    {
        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            //var userId = Context.UserIdentifier;

            //until we have upload brand feature
            var userId = httpContext.Request.Query["userId"].ToString();

            if (!string.IsNullOrEmpty(userId))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, userId);
            }

            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var httpContext = Context.GetHttpContext();
            var userId = httpContext.Request.Query["userId"].ToString();

            if (!string.IsNullOrEmpty(userId))
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, userId);
            }

            await base.OnDisconnectedAsync(exception);
        }
    }
}
