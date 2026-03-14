using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec
{
    public class GetNotificationsCursorSpec : Specification<Notification>
    {
        public GetNotificationsCursorSpec(string userId,
                                          bool? unreadOnly = null,
                                          DateTime? lastNotificationDate = null,
                                          int take = 20)
        {
            AddCriteria(n => n.UserId == userId);
            if (unreadOnly.HasValue)
            {
                if (unreadOnly.Value)         
                    AddCriteria(n => !n.IsRead);
                else                         
                    AddCriteria(n => n.IsRead);
            }
            if (lastNotificationDate.HasValue)
                AddCriteria(n => n.CreatedAt < lastNotificationDate.Value);

            AddOrderByDescending(n => n.CreatedAt);
            ApplyPaging(1, take);


        }
    }
}
