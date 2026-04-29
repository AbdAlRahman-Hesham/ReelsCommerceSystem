using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.ChatRoom;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ChatRoomSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public ChatRoomService(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<int> CreateRoom(string user1, string user2)
        {
            var repo = _unitOfWork.Repository<ChatRoom>();

            var spec = new ExistingChatRoomSpec(user1, user2);

            var existing = await repo.GetWithSpecAsync(spec);

            if (existing != null)
                return existing.Id;

            var room = new ChatRoom
            {
                User1Id = user1,
                User2Id = user2,
                CreatedAt = DateTime.UtcNow
            };

            await repo.AddAsync(room);
            await _unitOfWork.SaveChangesAsync();

            return room.Id;
        }

        public async Task DeleteRoom(int roomId)
        {
            var roomRepo = _unitOfWork.Repository<ChatRoom>();
            var messageRepo = _unitOfWork.Repository<Message>();

            var room = await roomRepo.GetByIdAsync(roomId);

            if (room == null)
                throw new NotFoundException("Room not found");
            var spec = new MessagesByRoomSpec(roomId);

            var messages = await messageRepo.GetAllWithSpecAsync(spec);

            messageRepo.DeleteRangeAsync(messages);
            roomRepo.Delete(room);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<int> GetUnreadCount(int roomId, string userId)
        {
            var spec = new MessagesByRoomSpec(roomId);
            var messages = await _unitOfWork.Repository<Message>().GetAllWithSpecAsync(spec);

            return messages.Count(m =>
                m.SenderId != userId &&
                m.Status != MessageStatus.Seen);
        }

        public async Task<IEnumerable<ChatRoomRes>> GetUserRooms(string userId)
        {
            var spec = new ChatRoomsByUserSpec(userId);
            var rooms = await _unitOfWork.Repository<ChatRoom>().GetAllWithSpecAsync(spec);

            var result = new List<ChatRoomRes>();

            foreach (var room in rooms)
            {
                var otherUserId = room.User1Id == userId ? room.User2Id : room.User1Id;
                var otherUser = await _userManager.FindByIdAsync(otherUserId);

                var unread = room.Messages.Count(m =>
                    m.SenderId != userId &&
                    m.Status != MessageStatus.Seen);

                result.Add(new ChatRoomRes
                {
                    RoomIdEnc = EncryptionHelper.Encrypt(room.Id.ToString()),
                    UserName = $"{otherUser?.FirstName} {otherUser?.LastName}",
                    UserImageUrl = otherUser?.ImageURL ?? string.Empty,
                    UnreadCount = unread
                });
            }

            return result;
        }

        public async Task<ChatRoomRes> GetRoomRes(int roomId, string userId)
        {
            var room = await _unitOfWork.Repository<ChatRoom>().GetByIdAsync(roomId);
            if (room == null) return null;

            var otherUserId = room.User1Id == userId ? room.User2Id : room.User1Id;
            var otherUser = await _userManager.FindByIdAsync(otherUserId);

            return new ChatRoomRes
            {
                RoomIdEnc = EncryptionHelper.Encrypt(room.Id.ToString()),
                UserName = $"{otherUser?.FirstName} {otherUser?.LastName}",
                UserImageUrl = otherUser?.ImageURL ?? string.Empty,
                UnreadCount = 0
            };
        }
    }
}
