using ReelsCommerceSystem.Domain.Entities.CartEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Repositories
{
    public interface ICartRepository
    {
        Task<Cart?> GetUserCartAsync(string userId);
        Task AddCartAsync(Cart cart);
        Task UpdateCartAsync(Cart cart);
    }
}
