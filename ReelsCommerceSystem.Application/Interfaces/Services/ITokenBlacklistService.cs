using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ITokenBlacklistService
    {
        Task AddAsync(string token);
        Task<bool> IsBlacklistedAsync(string token);
    }
}
