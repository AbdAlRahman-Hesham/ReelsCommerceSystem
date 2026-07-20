using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec
{
    public class GetNotificationById : Specification<Notification>
    {
        public GetNotificationById(int notificationId, string userId)
        {
            AddCriteria(n => n.Id == notificationId && n.UserId == userId);

        }
    }
}
