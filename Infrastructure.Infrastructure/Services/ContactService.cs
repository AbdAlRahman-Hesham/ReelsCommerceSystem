using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        public async Task<ApiResponse<string>> SendMessageAsync(ContactMessageReq request, string? userId)
        {
            var message = new ContactMessage
            {
                UserId = userId,
                Name = request.Name,
                Email = request.Email,
                Message = request.Message
            };

            await _unitOfWork.Repository<ContactMessage>().AddAsync(message);
            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<string>.SuccessResponse
                (
                       "Message sent successfully",
                        HttpStatusCode.OK,
                       "Message sent successfully.",
                        "تم إرسال الرسالة بنجاح."
                );
        }
    }
}
