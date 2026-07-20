using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.CommunityEntities
{
    public class PostLike :BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int PostId { get; set; }
        public CommunityPost Post { get; set; } = null!;
    }
}
