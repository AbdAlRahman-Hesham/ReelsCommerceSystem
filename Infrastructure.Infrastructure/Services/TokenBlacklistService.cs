using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BlacklistToken;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class TokenBlacklistService : ITokenBlacklistService
    {
        private readonly AppDbContext _dbContext;

        public TokenBlacklistService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(string token)
        {

            if (string.IsNullOrWhiteSpace(token))
                return;

    
            token = token.StartsWith("Bearer ") ? token.Substring(7).Trim() : token.Trim();

          
            bool exists = await _dbContext.BlacklistedTokens.AnyAsync(x => x.Token == token);
            if (exists) return;

           
            var entity = new BlacklistedToken { Token = token };
            _dbContext.BlacklistedTokens.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsBlacklistedAsync(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) return false;
            token = token.StartsWith("Bearer ") ? token.Substring(7).Trim() : token.Trim();

            return await _dbContext.BlacklistedTokens.AnyAsync(x => x.Token == token);
        }
    }
}
