using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Request.Interest;
using ReelsCommerceSystem.Application.DTOs.Response.Interest;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IInterestService
    {
        Task<List<UserInterestResDto>> GetAllInterestsAsync();
    }
}
