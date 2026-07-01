using ReelsCommerceSystem.Application.DTOs.Request.Notification;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface INotificationService
{
    Task<Notification> CreateNotificationAsync(CreateNotificationReq Dto);
    Task<ApiResponse<List<Notification>>> GetNotificationsAsync(
        string userId,
        bool? unreadOnly = null,
        DateTime? lastNotificationDate = null,
        int take = 20);

    Task<ApiResponse<string>> MarkAllAsReadAsync(string userId);
    Task<ApiResponse<string>> MarkAsReadAsync(int notificationId, string userId);
    Task<ApiResponse<int>> GetUnreadCountAsync(string userId);
    Task<ApiResponse<bool>> DeleteNotificationAsync(int notificationId, string userId);
    Task<ApiResponse<bool>> ClearAllNotificationsAsync(string userId);
    Task SendNewVideoNotificationAsync(int brandId, int reelId);
    Task SendOrderStatusNotificationAsync(Order order, OrderStatus newStatus);
    Task SendPaymentNotificationAsync(Order order, PaymentStatus status);
    Task SendBrandSubmittedNotificationAsync(Brand brand);
    Task SendBrandApprovedNotificationAsync(Brand brand);
    Task SendBrandRejectedNotificationAsync(Brand brand, string reason);
    Task SendBrandBannedNotificationAsync(Brand brand, string? reason = null);

    Task SendCancellationNotificationAsync(Order order, string cancelledByUserId, string cancelledByRole);
    Task SendRefundNotificationAsync(Order order);
    Task SendAdminRefundRequestNotificationAsync(Order order);
}
