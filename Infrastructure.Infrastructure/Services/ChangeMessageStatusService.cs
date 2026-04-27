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

        public ChangeMessageStatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<string>> ChangeStatusAsync(
            string userId,
            string roomIdEnc,
            string status,
            List<string> messageIdsEncrypted)
        {
            //  decrypt roomId
            var roomId = int.Parse(
                EncryptionHelper.Decrypt(Uri.UnescapeDataString(roomIdEnc)));

            //  validate + parse status
            if (!Enum.TryParse<MessageStatus>(status, true, out var parsedStatus))
                throw new Exception("Invalid status");

            //  decrypt messageIds
            var ids = messageIdsEncrypted
                .Select(id =>
                {
                    var cleaned = Uri.UnescapeDataString(id);
                    var decrypted = EncryptionHelper.Decrypt(cleaned);

                    if (!int.TryParse(decrypted, out var parsedId))
                        throw new Exception("Invalid messageId");

                    return parsedId;
                })
                .ToList();

            if (!ids.Any())
            {
                return ApiResponse<string>.SuccessResponse(
                    "No message ids provided",
                    HttpStatusCode.OK,
                    "لم يتم إرسال رسائل",
                    "No messages sent"
                );
            }


            // get messages
            var spec = new MessagesByIdsSpec(ids, roomId);

            var messages = await _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>()
                .GetAllWithSpecAsync(spec);

            if (!messages.Any())
            {
                return ApiResponse<string>.SuccessResponse(
                    "No messages found",
                    HttpStatusCode.OK,
                    "لا توجد رسائل",
                    "No messages found"
                );
            }
            int updatedCount = 0;
            int skippedCount = 0;

            // update status
            foreach (var message in messages)
            {
                Console.WriteLine($"Before: {message.Status}");

                if (message.SenderId == userId)
                {
                    skippedCount++;
                    continue;
                }
                if (message.Status >= parsedStatus)
                {
                    skippedCount++;
                    continue;
                }
                    message.Status = parsedStatus;
                Console.WriteLine($"After: {message.Status}");
                _unitOfWork.Repository<Domain.Entities.ChatEntities.Message>().Update(message);
                updatedCount++;


            }
            if (updatedCount == 0)
            {
                return ApiResponse<string>.SuccessResponse(
                    $"No messages were updated (already in {parsedStatus})",
                    HttpStatusCode.OK,
                    "لا يوجد تحديثات",
                    "Nothing changed"
                );
            }

            //  save
            await _unitOfWork.SaveChangesAsync();
            return ApiResponse<string>.SuccessResponse(
               $"{updatedCount} messages updated, {skippedCount} skipped",
               HttpStatusCode.OK,
               "تم التحديث بنجاح",
               "Messages updated successfully"
             );

            //  event hook 
            // TODO: invoke event
        }
    }
}
