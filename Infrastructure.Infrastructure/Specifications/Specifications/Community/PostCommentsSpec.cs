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
    public class PostCommentsSpec : Specification<PostComment>
    {
        public PostCommentsSpec(int postId)
            :base(c=>c.PostId==postId)
        {
            AddIncludeChain(query =>
            query.Include(c => c.Brand)
                 .ThenInclude(b => b.user));

            AddInclude(c => c.CommentLikes);

            AddIncludeChain(query =>
                query.Include(c => c.Replies)
                     .ThenInclude(r => r.Brand)
                     .ThenInclude(b => b.user));

            AddIncludeChain(query =>
                query.Include(c => c.Replies)
                     .ThenInclude(r => r.CommentLikes));

            AddIncludeChain(query =>
                query.Include(c => c.Replies)
                     .ThenInclude(r => r.Replies));

            AddOrderByDescending(c => c.CreatedAt);


        }
    }
}
