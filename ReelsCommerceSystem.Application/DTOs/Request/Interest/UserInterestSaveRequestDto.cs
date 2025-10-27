using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Interest
{
    public class UserInterestSaveRequestDto
    {
        public List<int> InterestIds { get; set; } = new();
    }
}
