using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Interest
{
    public class UserInterestResultDto
    {
        public string UserId { get; set; }
        public List<int> SelectedInterests { get; set; }
    }
}
