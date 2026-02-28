using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OrderSpec
{
    public class OrderByIdWithOrderProductSpes : Specification<Order>
    {
        public OrderByIdWithOrderProductSpes(int OrderId) 
            : base( o => o.Id == OrderId )
        {
            AddInclude( o => o.OrderProducts );
            AddInclude(o => o.User);

        }

    }
}
