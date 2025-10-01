using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.UserInterestEntities
{
    public class UserInterest:BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; } = null!;
        public string Interests { get; set; } = null!;

    }
}
