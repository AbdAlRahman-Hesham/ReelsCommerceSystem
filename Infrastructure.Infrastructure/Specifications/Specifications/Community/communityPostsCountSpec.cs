using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Community
{
    public class communityPostsCountSpec :Specification<CommunityPost>
    {
        public communityPostsCountSpec(int brandId)
            :base(p =>

            p.Status == PostStatus.Published

            ||

            // my drafts only
            (p.Status == PostStatus.Draft &&
             p.BrandId == brandId)
        )
        {
            
        }
    }
}
