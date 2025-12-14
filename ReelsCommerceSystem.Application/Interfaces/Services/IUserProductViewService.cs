using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IUserProductViewService
    {
        Task RecordProductViewAsync(string userId, int productId);
        Task<IReadOnlyList<UserProductViewDto>> GetRecentViewsAsync(string userId, int limit);
    }
}
