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
    public class CommentByIdSpec :Specification<PostComment>
    {
        public CommentByIdSpec(int commentId)
            :base(c=>c.Id==commentId)
        {
            AddIncludeChain(query =>
            query.Include(c => c.Brand)
            .ThenInclude(b => b.user));

            AddInclude(c => c.CommentLikes);
            AddInclude(c => c.Replies);

            AddOrderByDescending(c => c.CreatedAt);

        }
    }
}
