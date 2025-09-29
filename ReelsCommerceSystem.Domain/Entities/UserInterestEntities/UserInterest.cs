using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.UserInterestEntities
{
    public class UserInterest
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Interests { get; set; } = null!;

    }
}
