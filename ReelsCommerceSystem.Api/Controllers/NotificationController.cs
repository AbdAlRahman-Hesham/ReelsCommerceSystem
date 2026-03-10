using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    [Authorize]
    public class NotificationController : AppBaseController
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetNotifications(
            [FromQuery] bool? unreadOnly = null,
            [FromQuery] DateTime? lastNotificationDate = null,
            [FromQuery] int take = 20)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                return Unauthorized(new { message = "Invalid token or user not found." });

            var response = await _notificationService.GetNotificationsAsync(
                userId, unreadOnly, lastNotificationDate, take
            );
            return StatusCode(response.StatusCode, response);
        


        }
        [HttpPut("mark-all-read")]
        public async Task<IActionResult> MarkAllAsRead()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();
            var response = await _notificationService.MarkAllAsReadAsync(userId);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPatch("{id}/read")]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var response = await _notificationService.MarkAsReadAsync(id, userId);

            return StatusCode(response.StatusCode, response);

        }
        [HttpGet("unread-count")]
        public async Task<IActionResult> GetUnreadCount()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var response = await _notificationService.GetUnreadCountAsync(userId);

            return StatusCode(response.StatusCode, response);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var response = await _notificationService.DeleteNotificationAsync(id, userId);
            return StatusCode(response.StatusCode, response);
        }
        [HttpDelete("clear-all")]
        public async Task<IActionResult> ClearAllNotifications()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var response = await _notificationService.ClearAllNotificationsAsync(userId);
            return StatusCode(response.StatusCode, response);
        }

    }

}
