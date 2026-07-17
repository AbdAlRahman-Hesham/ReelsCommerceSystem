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
        private readonly IEmailService _emailService;
        public ContactService(IUnitOfWork unitOfWork, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
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

            try
            {
                await _emailService.SendContactEmailAsync(request.Name, request.Email, request.Message);
            }
            catch
            {
                // Email failure should not break the contact form submission
            }

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
