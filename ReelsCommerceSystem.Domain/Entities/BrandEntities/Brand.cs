using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class Brand : BaseEntity
{
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public string? CoverImageUrl { get; set; }
    public string? LogoPublicId { get; set; }
    public string? CoverPublicId { get; set; }
    public string ReturnPolicyAsHtml { get; set; } = null!;
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public ICollection<UserBrandFollow> UserFollows { get; set; } = new List<UserBrandFollow>();
    public ICollection<BrandReview> Reviews { get; set; } = new List<BrandReview>();
    public ICollection<Reel> Reels { get; set; } = new List<Reel>();
    public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    public ICollection<BrandSocialLink> SocialLinks { get; set; } = new List<BrandSocialLink>();

    public ICollection<PostComment> PostComments { get; set; } = new HashSet<PostComment>();
    public ICollection<PostCommentLike> PostCommentLikes { get; set; } = new HashSet<PostCommentLike>();
    public ICollection<CommunityPost> Posts { get; set; } = new HashSet<CommunityPost>();
    public ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>();

    public double AverageRating { get; set; } = 0;
    public int NumOfReviews { get; set; } = 0;

    public string UserId { get; set; }
    public User user { get; set; }

    public BrandStatus Status { get; set; }
    public BrandStep CurrentStep { get; set; }

    public int? RejectionReasonId { get; set; }
    public RejectionReason? RejectionReason { get; set; }

    public string Category { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Governorate { get; set; } = null!;
    public string District { get; set; } = null!;
    public int NumberOfEmployees { get; set; }
    public BrandVerification? BrandVerification { get; set; }

    public BrandStep? LastFailedStep { get; set; }
    public DateTime? SubmittedAt { get; set; }

    public string? PayoutPhoneNumber { get; set; }
    public string? BankAccountNumber { get; set; }
    public string? BankCode { get; set; }
}


