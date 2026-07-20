using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Application.DTOs.Dto;
using ReelsCommerceSystem.Application.DTOs.Request.Notification;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Senders;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public  class NotificationService : INotificationService
    {
        private readonly INotificationRealtimeSender _realtimeSender;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public NotificationService(INotificationRealtimeSender realtimeSender
            , IUnitOfWork unitOfWork
            , UserManager<User> userManager)
        {
            _realtimeSender = realtimeSender;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<Notification> CreateNotificationAsync(CreateNotificationReq Dto)
        {
            var notification = new Notification
            {
                UserId = Dto.UserId,
                Type = Dto.Type,
                ReferenceId = Dto.ReferenceId,
                Message = Dto.Message,
                MessageAr = Dto.MessageAr,
                IsRead = false
            };
            await _unitOfWork.Repository<Notification>().AddAsync(notification);
            await _unitOfWork.Repository<Notification>().SaveChangesAsync();

            return notification;
        }

        public async Task<ApiResponse<List<Notification>>> GetNotificationsAsync(
                                string userId,
                                bool? unreadOnly = null,
                                DateTime? lastNotificationDate = null,
                                int take = 20)
        {
            var spec = new GetNotificationsCursorSpec(userId, unreadOnly, lastNotificationDate, take);
            var notifications = await _unitOfWork.Repository<Notification>().GetAllWithSpecAsync(spec);
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
            var notifications = await _unitOfWork.Repository<Notification>().GetAllWithSpecAsync(spec);

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

                _unitOfWork.Repository<Notification>().Update(notification);
            }
            await _unitOfWork.Repository<Notification>().SaveChangesAsync();
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
            var notification = await _unitOfWork.Repository<Notification>().GetWithSpecAsync(spec);

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

            _unitOfWork.Repository<Notification>().Update(notification);

            await _unitOfWork.Repository<Notification>().SaveChangesAsync();

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

            var count = await _unitOfWork.Repository<Notification>().CountAsync(spec);
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
            var notification = await _unitOfWork.Repository<Notification>().GetByIdAsync(notificationId);
            if (notification == null || notification.UserId != userId)
            {
                return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound,
                    "Notification not found.",
                    "لم يتم العثور على الإشعار.");
            }
            _unitOfWork.Repository<Notification>().Delete(notification);
            await _unitOfWork.Repository<Notification>().SaveChangesAsync();

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
            var notifications = await _unitOfWork.Repository<Notification>().GetAllWithSpecAsync(spec);

            foreach (var notification in notifications)
                _unitOfWork.Repository<Notification>().Delete(notification);

            await _unitOfWork.Repository<Notification>().SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse
                (
                   true, 
                   HttpStatusCode.OK,
                   "All notifications cleared.",
                   "تم مسح جميع الإشعارات."
                );


        }
        public async Task SendNewVideoNotificationAsync(int brandId,int reelId)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(brandId);
            if (brand == null) throw new NotFoundException("Brand not found");

            var followers = await _unitOfWork.Repository<UserBrandFollow>()
                        .GetAllWithSpecAsync(new GetFollowersOfBrandSpec(brandId));
            var followerIds = followers.Select(f => f.UserId).ToList();
            if (!followerIds.Any()) return;

            var notifications = followerIds.Select(userId => new Notification
            {
                UserId = userId,
                Type = NotificationType.VIDEO,
                ReferenceId = reelId,
                Message = $"{brand.DisplayName} just uploaded a new video! Check it out!",
                MessageAr = $"{brand.DisplayName} قام للتو برفع فيديو جديد! شاهد الآن!",
                IsRead = false
            }).ToList();

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddRangeAsync(notifications);
            await notificationRepo.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.VIDEO,
                ReferenceId = reelId,
                Message = $"{brand.DisplayName} just uploaded a new video!",
                MessageAr = $"{brand.DisplayName} قام للتو برفع فيديو جديد!"
            };
            await _realtimeSender.SendNotificationToUsersAsync(followerIds, realtimeNotification);

    

            var unreadCounts = await notificationRepo
                                   .GetAllWithSpecAsync(new GetUnreadNotificationsForUsersSpec(followerIds));

            var unreadCountDict = unreadCounts
                .GroupBy(n => n.UserId)
                .ToDictionary(g => g.Key, g => g.Count());

            var tasks = followerIds.Select(userId =>
            {
                unreadCountDict.TryGetValue(userId, out int count);
                return _realtimeSender.UpdateUnreadCountAsync(userId, count);
            });

            await Task.WhenAll(tasks);
        }

        public async Task SendOrderStatusNotificationAsync(Order order, OrderStatus newStatus)
        {
            string message = newStatus switch
            {
                OrderStatus.Pending => "Your order is pending.",
                OrderStatus.Processing => "Your order is being processed.",
                OrderStatus.Preparing => "Your order is being prepared.",
                OrderStatus.Packed => "Your order has been packed and is ready for shipping.",
                OrderStatus.Shipped => "Your order has been shipped!",
                OrderStatus.Delivered => "Your order has been delivered! Enjoy!",
                OrderStatus.Cancelled => "Your order has been cancelled.",
                OrderStatus.PendingCancellation => "Your cancellation request is pending admin approval.",
                _ => $"Your order status has changed to {newStatus}."
            };

            string messageAr = newStatus switch
            {
                OrderStatus.Pending => "طلبك قيد الانتظار.",
                OrderStatus.Processing => "طلبك قيد التنفيذ.",
                OrderStatus.Preparing => "طلبك قيد التحضير.",
                OrderStatus.Packed => "تم تغليف طلبك وهو جاهز للشحن.",
                OrderStatus.Shipped => "تم شحن طلبك!",
                OrderStatus.Delivered => "تم توصيل طلبك! استمتع به!",
                OrderStatus.Cancelled => "تم إلغاء طلبك.",
                OrderStatus.PendingCancellation => "طلب الإلغاء الخاص بك في انتظار موافقة المدير.",
                _ => $"تغيرت حالة طلبك إلى {newStatus}."
            };

            var notification = new Notification
            {
                UserId = order.UserId,
                Type = NotificationType.ORDER_STATUS,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            // Send Realtime Notification
            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.ORDER_STATUS,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { order.UserId }, realtimeNotification);

            // Update Unread Counter
            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(order.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(order.UserId, unreadCount);
        }
        public async Task SendPaymentNotificationAsync(Order order, PaymentStatus status)
        {
            string message = status switch
            {
                PaymentStatus.Paid => $"Payment successful! Your order #{order.Id} is now being processed.",
                PaymentStatus.Failed => $"Payment failed for order #{order.Id}. Please try again or use another payment method.",
                PaymentStatus.Refunded => $"Payment for order #{order.Id} has been refunded.",
                PaymentStatus.Voided => $"Payment for order #{order.Id} has been voided.",
                _ => $"Payment status for order #{order.Id} is now {status}."
            };

            string messageAr = status switch
            {
                PaymentStatus.Paid => $"نجحت عملية الدفع! طلبك #{order.Id} قيد التنفيذ الآن.",
                PaymentStatus.Failed => $"فشلت عملية الدفع للطلب #{order.Id}. يرجى المحاولة مرة أخرى أو استخدام وسيلة دفع أخرى.",
                PaymentStatus.Refunded => $"تم استرداد مبلغ الدفع للطلب #{order.Id}.",
                PaymentStatus.Voided => $"تم إبطال عملية الدفع للطلب #{order.Id}.",
                _ => $"حالة الدفع للطلب #{order.Id} هي الآن {status}."
            };

            var notification = new Notification
            {
                UserId = order.UserId,
                Type = NotificationType.PAYMENT,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            // Send Realtime Notification
            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.PAYMENT,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { order.UserId }, realtimeNotification);

            // Update Unread Counter
            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(order.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(order.UserId, unreadCount);
        }

        public async Task SendBrandSubmittedNotificationAsync(Brand brand)
        {
            var admins = await _userManager.GetUsersInRoleAsync(SystemRoles.Admin);
            var adminIds = admins.Select(a => a.Id).ToList();
            if (!adminIds.Any()) return;

            string message = "New brand request submitted";
            string messageAr = "تم إرسال طلب براند جديد";

            var notifications = adminIds.Select(adminId => new Notification
            {
                UserId = adminId,
                Type = NotificationType.BRAND_SUBMITTED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            }).ToList();

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddRangeAsync(notifications);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.BRAND_SUBMITTED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(adminIds, realtimeNotification);

            // Update unread counts for admins
            foreach (var adminId in adminIds)
            {
                var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(adminId));
                await _realtimeSender.UpdateUnreadCountAsync(adminId, unreadCount);
            }
        }

        public async Task SendBrandApprovedNotificationAsync(Brand brand)
        {
            string message = "Your brand has been approved";
            string messageAr = "تمت الموافقة على البراند الخاص بك";

            var notification = new Notification
            {
                UserId = brand.UserId,
                Type = NotificationType.BRAND_APPROVED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.BRAND_APPROVED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { brand.UserId }, realtimeNotification);

            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(brand.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(brand.UserId, unreadCount);
        }

        public async Task SendBrandRejectedNotificationAsync(Brand brand, string reason)
        {
            string message = $"Your request was rejected: {reason}";
            string messageAr = $"تم رفض طلبك: {reason}";

            var notification = new Notification
            {
                UserId = brand.UserId,
                Type = NotificationType.BRAND_REJECTED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.BRAND_REJECTED,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { brand.UserId }, realtimeNotification);

            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(brand.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(brand.UserId, unreadCount);
        }

        public async Task SendBrandBannedNotificationAsync(Brand brand, string? reason = null)
        {
            string message = string.IsNullOrEmpty(reason)
                ? "Your brand has been banned."
                : $"Your brand has been banned: {reason}";
            string messageAr = string.IsNullOrEmpty(reason)
                ? "تم حظر البراند الخاص بك."
                : $"تم حظر البراند الخاص بك: {reason}";

            var notification = new Notification
            {
                UserId = brand.UserId,
                Type = NotificationType.SYSTEM,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.SYSTEM,
                ReferenceId = brand.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { brand.UserId }, realtimeNotification);

            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(brand.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(brand.UserId, unreadCount);
        }

        public async Task SendCancellationNotificationAsync(Order order, string cancelledByUserId, string cancelledByRole)
        {
            string roleLabel = cancelledByRole switch
            {
                SystemRoles.User => "Customer",
                string r when r == SystemRoles.BrandOwner || r == SystemRoles.BrandEmployee => "Brand",
                _ => cancelledByRole
            };

            string message = $"Order #{order.Id} has been cancelled by {roleLabel}.";
            string messageAr = $"تم إلغاء الطلب #{order.Id} بواسطة {roleLabel}.";

            var notificationRepo = _unitOfWork.Repository<Notification>();

            var brandUserIds = await _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
                .Where(op => op.OrderId == order.Id)
                .Include(op => op.Brand)
                .Select(op => op.Brand.UserId)
                .Distinct()
                .ToListAsync();

            var recipientIds = new List<string> { order.UserId };
            recipientIds.AddRange(brandUserIds.Where(id => id != order.UserId));

            var notifications = recipientIds.Select(uid => new Notification
            {
                UserId = uid,
                Type = NotificationType.ORDER_STATUS,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            }).ToList();

            await notificationRepo.AddRangeAsync(notifications);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.ORDER_STATUS,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(recipientIds, realtimeNotification);

            foreach (var uid in recipientIds)
            {
                var count = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(uid));
                await _realtimeSender.UpdateUnreadCountAsync(uid, count);
            }
        }

        public async Task SendRefundNotificationAsync(Order order)
        {
            string message = $"Your payment for order #{order.Id} has been refunded.";
            string messageAr = $"تم استرداد مبلغ الدفع للطلب #{order.Id}.";

            var notification = new Notification
            {
                UserId = order.UserId,
                Type = NotificationType.PAYMENT,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            };

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.PAYMENT,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(new List<string> { order.UserId }, realtimeNotification);

            var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(order.UserId));
            await _realtimeSender.UpdateUnreadCountAsync(order.UserId, unreadCount);
        }

        public async Task SendAdminRefundRequestNotificationAsync(Order order)
        {
            var admins = await _userManager.GetUsersInRoleAsync(SystemRoles.Admin);
            var adminIds = admins.Select(a => a.Id).ToList();
            if (!adminIds.Any()) return;

            string message = $"Refund requested for order #{order.Id}. Customer paid {order.TotalAmount:C} via {order.PaymentMethod}.";
            string messageAr = $"طلب استرداد للطلب #{order.Id}. دفع العميل {order.TotalAmount:C} عبر {order.PaymentMethod}.";

            var notifications = adminIds.Select(adminId => new Notification
            {
                UserId = adminId,
                Type = NotificationType.SYSTEM,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr,
                IsRead = false
            }).ToList();

            var notificationRepo = _unitOfWork.Repository<Notification>();
            await notificationRepo.AddRangeAsync(notifications);
            await _unitOfWork.SaveChangesAsync();

            var realtimeNotification = new RealtimeNotificationDto
            {
                Type = NotificationType.SYSTEM,
                ReferenceId = order.Id,
                Message = message,
                MessageAr = messageAr
            };
            await _realtimeSender.SendNotificationToUsersAsync(adminIds, realtimeNotification);

            foreach (var adminId in adminIds)
            {
                var unreadCount = await notificationRepo.CountAsync(new GetUnreadNotificationSpec(adminId));
                await _realtimeSender.UpdateUnreadCountAsync(adminId, unreadCount);
            }
        }
    }
}
