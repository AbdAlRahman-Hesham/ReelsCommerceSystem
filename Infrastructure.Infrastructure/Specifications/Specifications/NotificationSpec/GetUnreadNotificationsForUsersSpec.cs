using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.NotificationSpec
{
    public class GetUnreadNotificationsForUsersSpec :Specification<Notification>
    {
        public GetUnreadNotificationsForUsersSpec(List<string> userIds)
        {
            AddCriteria(n => userIds.Contains(n.UserId) && !n.IsRead);
        }
    }
}
