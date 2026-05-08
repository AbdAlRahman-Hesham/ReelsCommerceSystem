using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ChangeMessageStatusService : IChangeMessageStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ReelsCommerceSystem.Application.Interfaces.Senders.IChatSender _chatSender;

        public ChangeMessageStatusService(IUnitOfWork unitOfWork, ReelsCommerceSystem.Application.Interfaces.Senders.IChatSender chatSender)
        {
            _unitOfWork = unitOfWork;
            _chatSender = chatSender;
        }

        public async Task<ApiResponse<string>> ChangeStatusAsync(
            string userId,
            string roomIdEnc,
            MessageStatus status,
            List<string> messageIdsEncrypted)
        {
            //  decrypt roomId
            var roomIdStr = EncryptionHelper.Decrypt(roomIdEnc);
            if (!int.TryParse(roomIdStr, out var roomId))
                throw new Exception("Invalid roomId");

            //  decrypt messageIds
            var ids = messageIdsEncrypted
                .Select(id =>
                {
                    var decrypted = EncryptionHelper.Decrypt(id);
                    if (!int.TryParse(decrypted, out var parsedId))
                        throw new Exception("Invalid messageId");
                    return parsedId;
                })
                .ToList();

            // get messages
            IEnumerable<Domain.Entities.ChatEntities.Message> messages;

            if (ids.Any())
            {
                var spec = new MessagesByIdsSpec(ids, roomId);
                // We need tracking here because we are updating them
                messages = await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>()
                    .GetAllWithSpecAsync(spec);
            }
            else
            {
                // Optimize: only fetch messages that actually need updating
                // Create a dynamic query or a more specific spec
                messages = await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>()
                    .GetAllWithSpecAsync(new UnreadMessagesByRoomSpec(roomId, userId, status));
            }

            if (messages == null || !messages.Any())
            {
                return ApiResponse<string>.SuccessResponse("No messages to update", HttpStatusCode.OK);
            }

            int updatedCount = 0;

            var updatedPlainIds = new List<string>();

            // update status
            foreach (var message in messages)
            {
                // Cannot mark your own message as seen/delivered by you
                if (message.SenderId == userId) continue;

                // Only upgrade status (Pending -> Delivered -> Seen)
                if (message.Status < status)
                {
                    message.Status = status;
                    _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>().Update(message);
                    updatedCount++;
                    updatedPlainIds.Add(message.Id.ToString());
                }
            }

            if (updatedCount > 0)
            {
                await _unitOfWork.SaveChangesAsync();
                
                // Notify the sender of these messages
                var room = await _unitOfWork.Repository<ChatRoom>().GetByIdAsync(roomId);
                var recipientId = room.User1Id == userId ? room.User2Id : room.User1Id;

                if (status == MessageStatus.Seen)
                    await _chatSender.MessageSeen(roomId.ToString(), recipientId, updatedPlainIds);
                else if (status == MessageStatus.Delivered)
                    await _chatSender.MessageDelivered(roomId.ToString(), recipientId, updatedPlainIds);
            }

            return ApiResponse<string>.SuccessResponse(
               $"{updatedCount} messages updated",
               HttpStatusCode.OK,
               "تم التحديث بنجاح",
               "Messages updated successfully"
             );
        }
    }
}
