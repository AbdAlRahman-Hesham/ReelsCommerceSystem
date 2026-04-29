using ReelsCommerceSystem.Application.DTOs.Response.ChatRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IChatRoomService
    {
        Task<IEnumerable<ChatRoomRes>> GetUserRooms(string userId);
        Task<int> GetUnreadCount(int roomId, string userId);
        Task<int> CreateRoom(string user1, string user2);
        Task DeleteRoom(int roomId);
    }
}
