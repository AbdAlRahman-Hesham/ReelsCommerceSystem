using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IChangeMessageStatusService
    {
        Task<ApiResponse<string>> ChangeStatusAsync
            (
                     string userId,
                     string roomIdEnc,
                     ReelsCommerceSystem.Domain.Enums.MessageStatus status,
                     List<string> messageIdsEncrypted
            );
    }
}
