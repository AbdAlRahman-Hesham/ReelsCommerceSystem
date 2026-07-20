using ReelsCommerceSystem.Application.DTOs.Request.Message;
using ReelsCommerceSystem.Application.DTOs.Response.Chat;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<MessageRes> SendMessageAsync(string userId, SendMessageReq dto);
        Task<ApiResponse<PaginationResponse<MessageRes>>> GetMessagesAsync
             (
                     string userId,
                     string roomIdEncr,
                     int? page,
                     int? pageSize,
                     bool? unreadOnly,
                     string? afterMessageId
            );
        Task<ApiResponse<string>> DeleteMessageAsync(
                     string userId,
                     string messageIdEnc);
        Task<ApiResponse<string>> DeleteAllMessagesAsync(
    string userId,
    string roomIdEnc);
    }
}
