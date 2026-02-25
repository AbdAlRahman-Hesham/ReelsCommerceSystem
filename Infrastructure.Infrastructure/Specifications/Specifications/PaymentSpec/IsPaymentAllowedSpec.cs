using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.PaymentSpec
{
    public class IsPaymentAllowedSpec :Specification<Order>
    {
        public IsPaymentAllowedSpec()
            : base()
        {
            AddCriteria
            (o => o.OrderStatus == OrderStatus.Pending &&
            (o.PaymentStatus == PaymentStatus.Pending || o.PaymentStatus == PaymentStatus.Failed));

        }

        public bool IsSatisfiedBy(Order order) =>
        order.OrderStatus == OrderStatus.Pending &&
        (order.PaymentStatus == PaymentStatus.Pending || order.PaymentStatus == PaymentStatus.Failed);

    }
}
