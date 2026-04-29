using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Shared.Utilities;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.SignalR.Hubs;

public class ChatHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value 
                  ?? Context.User?.FindFirst("sub")?.Value 
                  ?? Context.User?.FindFirst("uid")?.Value;

        if (!string.IsNullOrEmpty(userId))
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userId);
        }
        else
        {
        }
        await base.OnConnectedAsync();
    }

    public async Task JoinPersonalGroup()
    {
        var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value 
                  ?? Context.User?.FindFirst("sub")?.Value 
                  ?? Context.User?.FindFirst("uid")?.Value;

        if (!string.IsNullOrEmpty(userId))
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userId);
        }
    }

    public async Task JoinRoom(string encryptedRoomId)
    {
        encryptedRoomId = encryptedRoomId.Replace(" ", "+");
        var roomId = EncryptionHelper.Decrypt(encryptedRoomId);
        await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
    }

    public async Task SendMessage(string encryptedRoomId, string encryptedMessage)
    {
        encryptedRoomId = encryptedRoomId.Replace(" ", "+");
        var roomId = EncryptionHelper.Decrypt(encryptedRoomId);
        
        // Note: ChatSender usually handles sending to group, 
        // but if called directly from client:
        await Clients.Group(roomId).SendAsync("OnReceiveMessage", encryptedMessage);
    }

    public async Task SeenMessage(string encryptedMessageId)
    {
        encryptedMessageId = encryptedMessageId.Replace(" ", "+");
        await Clients.All.SendAsync("OnMessageSeen", encryptedMessageId);
    }
    
    public async Task MessageDelivered(string encryptedMessageId)
    {
        encryptedMessageId = encryptedMessageId.Replace(" ", "+");
        await Clients.All.SendAsync("OnMessageDelivered", encryptedMessageId);
    }
}
