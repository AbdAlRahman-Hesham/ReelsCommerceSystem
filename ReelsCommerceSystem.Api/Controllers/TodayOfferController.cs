using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

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

    }
}
