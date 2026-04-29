using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Application.DTOs.Request.Message;
using ReelsCommerceSystem.Application.DTOs.Response.Chat;
using ReelsCommerceSystem.Application.Interfaces.Senders;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ChatService : IChatService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoServive _photoService;
        private readonly IChatSender _chatSender;
        public ChatService(
        IUnitOfWork unitOfWork,
        IPhotoServive photoService,
        IChatSender chatSender)
        {
            _unitOfWork = unitOfWork;
            _photoService = photoService;
            _chatSender = chatSender;
        }

        public async Task<MessageRes> SendMessageAsync(string userId, SendMessageReq dto)
        {
            // Decrypt RoomId
            var roomId = int.Parse(EncryptionHelper.Decrypt(dto.RoomId));

            var text = string.IsNullOrEmpty(dto.Text)
           ? null
           : EncryptionHelper.Decrypt(dto.Text);

            //Validate room
            var room = await _unitOfWork.Repository<ChatRoom>().GetByIdAsync(roomId);

            if (room == null ||
               (room.User1Id != userId && room.User2Id != userId))
            {
                throw new Exception("Unauthorized");
            }

            // Validate message
            if (string.IsNullOrEmpty(text) && dto.ImageUrl == null)
                throw new Exception("Message empty");

           

            //  Create message
            var message = new Message
            {
                RoomId = roomId,
                SenderId = userId,
                Text = text,
                ImageUrl = dto.ImageUrl,
                Status = MessageStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };
            await _unitOfWork.Repository<Message>().AddAsync(message);

            // 500 rule
            var spec = new MessageCountSpec(roomId);
            var count = await _unitOfWork.Repository<Message>().CountAsync(spec);
            if (count >= 500)
            {
                var oldest = (await _unitOfWork.Repository<Message>()
                    .GetAllAsync())
                    .Where(m => m.RoomId == roomId)
                    .OrderBy(m => m.CreatedAt)
                    .FirstOrDefault();

                if (oldest != null)
                    _unitOfWork.Repository<Message>().Delete(oldest);
            }
            // save Db
            await _unitOfWork.SaveChangesAsync();

            // update message
            message.Status = MessageStatus.DeliveredToServer;
            await _unitOfWork.SaveChangesAsync();

            
            // response (encrypted)
            var response = new MessageRes
            {
                MessageId = EncryptionHelper.Encrypt(message.Id.ToString()),
                RoomId = dto.RoomId,
                Text = message.Text != null ? EncryptionHelper.Encrypt(message.Text) : null,
                ImageUrl = message.ImageUrl != null ? EncryptionHelper.Encrypt(message.ImageUrl) : null,
                Status = message.Status.ToString(),
                CreatedAt = message.CreatedAt
            };

            // send real-time
            await _chatSender.SendMessage(roomId.ToString(), response);

            return response;

        }
    }
}
