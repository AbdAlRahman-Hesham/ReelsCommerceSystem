using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Shared.Utilities;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.SignalR.Hubs;

public class ChatHub : Hub
{

    public async Task JoinRoom(string encryptedRoomId)
    {
        var roomId = EncryptionHelper.Decrypt(encryptedRoomId);
        await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
    }

    public async Task SendMessage(string encryptedRoomId, string encryptedMessage)
    {
        var roomId = EncryptionHelper.Decrypt(encryptedRoomId);
        var message = EncryptionHelper.Decrypt(encryptedMessage);
        
        await Clients.Group(roomId).SendAsync("OnReceiveMessage", encryptedMessage);
    }

    public async Task SeenMessage(string encryptedMessageId)
    {
        var messageId = EncryptionHelper.Decrypt(encryptedMessageId);
        
        await Clients.All.SendAsync("OnMessageSeen", encryptedMessageId);
    }
    public async Task MessageDelivered(string encryptedMessageId)
    {
        var messageId = EncryptionHelper.Decrypt(encryptedMessageId);
        
        await Clients.All.SendAsync("OnMessageDelivered", encryptedMessageId);
    }
}
