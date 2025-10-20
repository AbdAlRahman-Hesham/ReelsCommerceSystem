using ReelsCommerceSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities
{
    //ERD
    public class BrandReviewLike:BaseEntity
    {
        public int ReviewId { get; set; }
        public string UserId { get; set; }
        public BrandReview Review { get; set; } = null!;

    }
}
