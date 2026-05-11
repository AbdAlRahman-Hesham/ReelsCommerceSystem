using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReelsCommerceSystem.Domain.Entities.CommunityEntities
{
    public class CommunityPost : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string CoverImageUrl { get; set; } = string.Empty;

        public PostStatus Status { get; set; } = PostStatus.Draft;

        public bool CommentsEnabled { get; set; } = true;

        public int BrandId { get; set; }


        //Navigational
        public Brand Brand { get; set; } = null!;
        public ICollection<PostComment> Comments { get; set; } = new HashSet<PostComment>();
        public ICollection<PostLike> Likes { get; set; }= new HashSet<PostLike>();

    }
}
