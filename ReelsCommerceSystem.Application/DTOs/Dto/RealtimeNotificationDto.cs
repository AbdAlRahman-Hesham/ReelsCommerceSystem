using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Dto
{
    public class RealtimeNotificationDto
    {
        public NotificationType Type { get; set; }
        public int ReferenceId { get; set; }
        public string Message { get; set; }
    }
}
