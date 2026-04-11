using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;


namespace ReelsCommerceSystem.Api.Controllers
{
    public class TestNotificationController : AppBaseController
    {
        private readonly INotificationService _notificationService;
        private readonly IUnitOfWork _unitOfWork;

        public TestNotificationController(INotificationService notificationService, IUnitOfWork unitOfWork)
        {
            _notificationService = notificationService;
            _unitOfWork = unitOfWork;
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

        [HttpPost("order/{orderId}/status")]
        public async Task<IActionResult> TestOrderStatusNotification(int orderId, [FromBody] OrderStatus status)
        {
            var orderRepo = _unitOfWork.Repository<Order>();
            var order = await orderRepo.GetByIdAsync(orderId);
            if (order == null) return NotFound("Order not found");

            await _notificationService.SendOrderStatusNotificationAsync(order, status);
            return Ok("Order status notification sent successfully.");
        }

        [HttpPost("order/{orderId}/payment")]
        public async Task<IActionResult> TestPaymentNotification(int orderId, [FromBody] PaymentStatus status)
        {
            var orderRepo = _unitOfWork.Repository<Order>();
            var order = await orderRepo.GetByIdAsync(orderId);
            if (order == null) return NotFound("Order not found");

            await _notificationService.SendPaymentNotificationAsync(order, status);
            return Ok("Payment notification sent successfully.");
        }

    }

}
