using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec
{
    public class GetUnreadNotificationSpec : Specification<Notification>
    {
        public GetUnreadNotificationSpec(string userId)
        {
            AddCriteria(n => n.UserId == userId && !n.IsRead);
        }
    }
}
