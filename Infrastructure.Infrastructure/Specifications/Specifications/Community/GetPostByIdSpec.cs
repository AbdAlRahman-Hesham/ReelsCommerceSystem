using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Community
{
    public class GetPostByIdSpec : Specification<CommunityPost>
    {
        public GetPostByIdSpec(int postId)
            : base(criteria: p => p.Id == postId)
        {

            AddIncludeChain(query => query
            .Include(p => p.Brand)
            .ThenInclude(b => b.user));


            AddInclude(p => p.Comments);
            AddInclude(p => p.Likes);

        }
    }
}
