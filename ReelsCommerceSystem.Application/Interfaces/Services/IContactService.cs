using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IContactService
    {
         Task<ApiResponse<string>> SendMessageAsync(ContactMessageReq request, string? userId);

    }
}
