using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Senders
{
    public interface INotificationRealtimeSender
    {
        Task SendNotificationToUsersAsync(List<string> userIds, object notification);

        Task UpdateUnreadCountAsync(string userId, int count);
    }
}
