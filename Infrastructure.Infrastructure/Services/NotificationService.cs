using ReelsCommerceSystem.Application.DTOs.Request.Notification;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public  class NotificationService : INotificationService
    {
        private readonly IGenericRepository<Notification> _notificationRepo;
        public NotificationService(IGenericRepository<Notification> notificationRepo)
        {
            _notificationRepo = notificationRepo;
        }
        public async Task<Notification> CreateNotificationAsync(CreateNotificationReq Dto)
        {
            var notification = new Notification
            {
                UserId = Dto.UserId,
                Type = Dto.Type,
                ReferenceId = Dto.ReferenceId,
                Message = Dto.Message,
                IsRead = false
            };
            await _notificationRepo.AddAsync(notification);
            await _notificationRepo.SaveChangesAsync();

            return notification;
        }

        public async Task<ApiResponse<List<Notification>>> GetNotificationsAsync(
                                string userId,
                                bool? unreadOnly = null,
                                DateTime? lastNotificationDate = null,
                                int take = 20)
        {
            var spec = new GetNotificationsCursorSpec(userId, unreadOnly, lastNotificationDate, take);
            var notifications = await _notificationRepo.GetAllWithSpecAsync(spec);
            return ApiResponse<List<Notification>>.SuccessResponse
                                               (
                                                 notifications.ToList(),
                                                 HttpStatusCode.OK,
                                                 "Notifications fetched successfully.",
                                                 "تم جلب الإشعارات بنجاح."
                                               );

        }
        public async Task<ApiResponse<string>> MarkAllAsReadAsync(string userId)
        {
            var spec = new GetUnreadNotificationSpec(userId);
            var notifications = await _notificationRepo.GetAllWithSpecAsync(spec);

            if (!notifications.Any())
            {
                return ApiResponse<string>.SuccessResponse(
                    "No unread notifications",
                    HttpStatusCode.OK,
                    "No unread notifications.",
                    "لا يوجد إشعارات غير مقروءة."
                );
            }
            foreach (var notification in notifications)
            {
                notification.IsRead = true;
                notification.UpdatedAt = DateTime.UtcNow;

                _notificationRepo.Update(notification);
            }
            await _notificationRepo.SaveChangesAsync();
            return ApiResponse<string>.SuccessResponse
                (
                     null,
                     HttpStatusCode.OK,
                    "All notifications marked as read.",
                    "تم تعليم كل الإشعارات كمقروءة."
                 );

        }
        public async Task<ApiResponse<string>> MarkAsReadAsync(int notificationId, string userId)
        {
            var spec = new GetNotificationById(notificationId, userId);
            var notification = await _notificationRepo.GetWithSpecAsync(spec);

            if (notification == null)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Notification not found.",
                    "الإشعار غير موجود."
                );
            }
            if (notification.IsRead)
            {
                return ApiResponse<string>.SuccessResponse(
                    null,
                    HttpStatusCode.OK,
                    "Notification already marked as read.",
                    "الإشعار مقروء بالفعل."
                );
            }
            notification.IsRead = true;
            notification.UpdatedAt = DateTime.UtcNow;

            _notificationRepo.Update(notification);

            await _notificationRepo.SaveChangesAsync();

            return ApiResponse<string>.SuccessResponse
                (
                      null,
                      HttpStatusCode.OK,
                      "Notification marked as read.",
                      "تم تعليم الإشعار كمقروء."
                );

        }
        public async Task<ApiResponse<int>> GetUnreadCountAsync(string userId)
        {
            var spec = new GetUnreadNotificationSpec(userId);

            var count = await _notificationRepo.CountAsync(spec);
            return ApiResponse<int>.SuccessResponse
                (
                         count,
                         HttpStatusCode.OK,
                         "Unread notifications count fetched successfully.",
                         "تم جلب عدد الإشعارات غير المقروءة."
                 );
        }
        public async Task<ApiResponse<bool>> DeleteNotificationAsync(int notificationId, string userId)
        {
            var notification = await _notificationRepo.GetByIdAsync(notificationId);
            if (notification == null || notification.UserId != userId)
            {
                return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound,
                    "Notification not found.",
                    "لم يتم العثور على الإشعار.");
            }
            _notificationRepo.Delete(notification);
            await _notificationRepo.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse
                ( true, 
                  HttpStatusCode.OK,
                  "Notification deleted successfully.",
                  "تم حذف الإشعار بنجاح."
                );
        }
        public async Task<ApiResponse<bool>> ClearAllNotificationsAsync(string userId)
        {
            var spec = new GetAllNotificationForUser (userId);
            var notifications = await _notificationRepo.GetAllWithSpecAsync(spec);

            foreach (var notification in notifications)
                _notificationRepo.Delete(notification);

            await _notificationRepo.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse
                (
                   true, 
                   HttpStatusCode.OK,
                   "All notifications cleared.",
                   "تم مسح جميع الإشعارات."
                );


        }
    }
}
