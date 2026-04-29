using Microsoft.AspNetCore.SignalR;
using ReelsCommerceSystem.Application.DTOs.Request.Message;
using ReelsCommerceSystem.Application.DTOs.Response.Chat;
using ReelsCommerceSystem.Application.Interfaces.Senders;
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
using Message = ReelsCommerceSystem.Domain.Entities.ChatEntities.Message;



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
            var message = new Domain.Entities.ChatEntities.Message
            {
                RoomId = roomId,
                SenderId = userId,
                Text = text,
                ImageUrl = dto.ImageUrl,
                Status = MessageStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };
            await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>().AddAsync(message);

            // 500 rule
            var spec = new MessageCountSpec(roomId);
            var count = await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>().CountAsync(spec);
            if (count >= 500)
            {
                var oldest = (await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>()
                    .GetAllAsync())
                    .Where(m => m.RoomId == roomId)
                    .OrderBy(m => m.CreatedAt)
                    .FirstOrDefault();

                if (oldest != null)
                    _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>().Delete(oldest);
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
        public async Task<ApiResponse<PaginationResponse<MessageRes>>> GetMessagesAsync(
     string userId,
     string roomIdEncr,
     int? page,
     int? pageSize,
     bool? unreadOnly,
     string? afterMessageId)
        {
            var roomId = int.Parse(SafeDecrypt(roomIdEncr));

            var currentPage = page ?? 1;
            var currentSize = pageSize ?? 20;
            var unread = unreadOnly ?? false;

            
            int pageIndexToUse;

            if (string.IsNullOrEmpty(afterMessageId))
            {
                //  normal pagination
                pageIndexToUse = currentPage;
            }
            else
            {
                //  cursor pagination → always page 1
                pageIndexToUse = 1;
            }

            var spec = new GetMessageSpec(
                roomId,
                userId,
                unread,
                afterMessageId,
                pageIndexToUse,
                currentSize);

            var messages = await _unitOfWork.Repository<Message>()
                .GetAllWithSpecAsync(spec);

            var countSpec = new MessageCountForGetSpec(
                roomId,
                userId,
                unread,
                afterMessageId);

            var totalCount = await _unitOfWork.Repository<Message>()
                .CountAsync(countSpec);

            var data = messages.Select(m => new MessageRes
            {
                MessageId = EncryptionHelper.Encrypt(m.Id.ToString()),
                RoomId = roomIdEncr,
                Text = m.Text != null ? EncryptionHelper.Encrypt(m.Text) : null,
                ImageUrl = m.ImageUrl != null ? EncryptionHelper.Encrypt(m.ImageUrl) : null,
                Status = m.Status.ToString(),
                CreatedAt = m.CreatedAt
            }).ToList();

            var meta = new Meta
            {
                PageNumber = pageIndexToUse,
                PageSize = currentSize,
                TotalRecords = totalCount,
                HasPreviousPage = pageIndexToUse > 1,
                HasNextPage = pageIndexToUse * currentSize < totalCount
            };

            return PaginationResponse<MessageRes>.SuccessResponse(
                data,
                meta,
                HttpStatusCode.OK,
                "Messages retrieved successfully",
                "تم جلب الرسائل بنجاح"
            );
        }

        public async Task<ApiResponse<string>> DeleteMessageAsync(
                     string userId,
                     string messageIdEnc)
        {
            try
            {
                //  decrypt id
                var cleaned = Uri.UnescapeDataString(messageIdEnc);
                var decrypted = EncryptionHelper.Decrypt(cleaned);

                if (!int.TryParse(decrypted, out var messageId))
                {
                    return ApiResponse<string>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Invalid message id",
                        "معرف الرسالة غير صحيح"
                    );
                }

                //  get message
                var message = await _unitOfWork.Repository<Message>()
                    .GetByIdAsync(messageId);

                if (message == null)
                {
                    return ApiResponse<string>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "Message not found",
                        "الرسالة غير موجودة"
                    );
                }

                //  authorization check
                if (message.SenderId != userId)
                {
                    return ApiResponse<string>.ErrorResponse(
                        HttpStatusCode.Forbidden,
                        "You are not allowed to delete this message",
                        "غير مسموح لك بحذف هذه الرسالة"
                    );
                }

                //  HARD DELETE
                _unitOfWork.Repository<Message>().Delete(message);

                await _unitOfWork.SaveChangesAsync();

                return ApiResponse<string>.SuccessResponse(
                    "Message deleted successfully",
                    HttpStatusCode.OK,
                    "تم حذف الرسالة بنجاح",
                    "Message deleted successfully"
                );
            }
            catch (Exception ex)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }
        public async Task<ApiResponse<string>> DeleteAllMessagesAsync(
    string userId,
    string roomIdEnc)
        {
            try
            {
                //  decrypt roomId
                var cleaned = Uri.UnescapeDataString(roomIdEnc);
                var decrypted = EncryptionHelper.Decrypt(cleaned);

                if (!int.TryParse(decrypted, out var roomId))
                {
                    return ApiResponse<string>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Invalid room id",
                        "معرف الغرفة غير صحيح"
                    );
                }

                //  get messages in room
                var messages = await _unitOfWork.Repository<Message>()
                     .GetAllWithSpecAsync(new MessagesByRoomSpec(roomId));

                if (messages == null || !messages.Any())
                {
                    return ApiResponse<string>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "No messages found in this room",
                        "لا توجد رسائل في هذه الغرفة"
                    );
                }

                
                //  HARD DELETE ALL
                await _unitOfWork.Repository<Message>().DeleteRangeAsync(messages);

                await _unitOfWork.SaveChangesAsync();

                return ApiResponse<string>.SuccessResponse(
                    "All messages deleted successfully",
                    HttpStatusCode.OK,
                    "تم حذف جميع الرسائل بنجاح",
                    "All messages deleted successfully"
                );
            }
            catch (Exception ex)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Something went wrong",
                    "حدث خطأ ما"
                );
            }
        }
        private string SafeDecrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // 1. remove URL encoding if موجود
            var cleaned = Uri.UnescapeDataString(input);

            // 2. decrypt
            return EncryptionHelper.Decrypt(cleaned);
        }
    }

}

