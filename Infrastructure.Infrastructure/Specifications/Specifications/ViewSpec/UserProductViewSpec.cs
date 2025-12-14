using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ViewSpec
{
    public class UserProductViewSpec: Specification<UserProductView>
    {
        public UserProductViewSpec(string userId, int productId)
          : base(x => x.UserId == userId && x.ProductId == productId)
        {
        }
    }
}
