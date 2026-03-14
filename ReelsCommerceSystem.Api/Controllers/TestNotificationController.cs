using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class TestNotificationController : AppBaseController
    {
        private readonly INotificationService _notificationService;

        public TestNotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("brand/{brandId}/reels/{reelId}/notify")]
        public async Task<IActionResult> SendNotification(int brandId, int reelId)
        {

            await _notificationService.SendNewVideoNotificationAsync(brandId, reelId);

            return Ok(new
            {
                Message = "Notifications sent successfully!",
                BrandId = brandId,
                ReelId = reelId
            });
        }

    }

}
