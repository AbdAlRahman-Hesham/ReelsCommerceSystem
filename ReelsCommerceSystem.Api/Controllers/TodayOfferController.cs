using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Application.Interfaces.Services;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class TodayOfferController: AppBaseController
    {
        private readonly IOfferService _offerService;

        public TodayOfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet("today offers")]
        public async Task<IActionResult> GetTodayOffers()
        {
            var response = await _offerService.GetTodayOffersAsync();
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost("offer")]
        public async Task<ActionResult> CreateOffer(CreateOfferReq request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _offerService.CreateOfferAsync(request, userId);

            return StatusCode(result.StatusCode, result);
        }
        [HttpPost("offer/{offerId}/image")]
        public async Task<ActionResult> UploadImage(int offerId, IFormFile file)
        {
            var result = await _offerService.UploadOfferImageAsync(offerId, file);

            return StatusCode(result.StatusCode, result);
        }

    }
}
