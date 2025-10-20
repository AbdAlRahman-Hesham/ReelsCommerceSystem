using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.SpecificationsParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec
{
    public class BrandReviewLikeSpec :Specification<BrandReviewLike>
    {
        public BrandReviewLikeSpec(string userId, ToggleLikeReq req) :
            base(
                criteria:(like => like.ReviewId == req.ReviewId && like.UserId == userId)
                )
        {
        }
        public BrandReviewLikeSpec(ToggleLikeReq req) :
            base(
                criteria: (like => like.ReviewId == req.ReviewId)
                )
        {
        }
    }
}
