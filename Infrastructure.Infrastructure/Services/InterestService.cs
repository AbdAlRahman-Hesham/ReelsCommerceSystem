using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Interest;
using ReelsCommerceSystem.Application.DTOs.Response.Interest;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class InterestService : IInterestService
    {
        private readonly AppDbContext _dbContext;

        public InterestService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserInterestResDto>> GetAllInterestsAsync()
        {
            var interests =await  _dbContext.Interests.ToListAsync();
            var InterestsList = interests.Select(i => new UserInterestResDto
            {
               Id=i.Id,
               Name=i.Name

            }).ToList();
            return InterestsList;
                
        }
    }
}
