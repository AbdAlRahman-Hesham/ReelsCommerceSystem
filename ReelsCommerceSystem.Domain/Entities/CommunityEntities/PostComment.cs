using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReelsCommerceSystem.Domain.Entities.CommunityEntities
{
    public class PostComment : BaseEntity
    {
        public int PostId { get; set; }

        public CommunityPost Post { get; set; } = null!;

        public int BrandId { get; set; }

        public Brand Brand { get; set; } = null!;

        public string Content { get; set; } = string.Empty;

        public int? ParentCommentId { get; set; }

        public PostComment? ParentComment { get; set; } = null!;

        public ICollection<PostComment> Replies { get; set; } = new HashSet<PostComment>();
        public ICollection<PostCommentLike> CommentLikes { get; set; }= new HashSet<PostCommentLike>();


    }
}
