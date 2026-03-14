using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class ContactUsController : AppBaseController
    {
        private readonly IContactService _contactService;
        public ContactUsController(IContactService contactService)
        {
            _contactService = contactService;
            
        }


        [AllowAnonymous]
        [HttpPost("contact")]
        public async Task<IActionResult> SendMessage(ContactMessageReq request)
        {
           
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _contactService.SendMessageAsync(request, userId);

            return StatusCode(result.StatusCode, result);
        }
    }
}
