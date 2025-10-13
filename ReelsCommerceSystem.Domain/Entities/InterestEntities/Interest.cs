using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;

namespace ReelsCommerceSystem.Domain.Entities.InterestEntities
{
    public class Interest:BaseEntity
    {
   
        public string Name { get; set; } = null!;
        public ICollection<UserInterest> UserInterests { get; set; } = new List<UserInterest>();
    }
}
