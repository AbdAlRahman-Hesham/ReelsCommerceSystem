using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Enums
{
   public enum OrderStatus
    {
        Pending,
        Processing,
        Preparing,
        Packed,
        Shipped,
        Delivered,
        Cancelled,
        PendingCancellation
    }
}
