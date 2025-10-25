using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.CartSpec;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Repositories
{
    public class CartRepository : CartGenericRepository<Cart>, ICartRepository

    {
        private readonly CartDbContext _context;

        public CartRepository(CartDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Cart?> GetUserCartAsync(string userId)
        {
            var spec = new CartPerUserWithItemWithProductSpec(userId);
            return await GetWithSpecAsync(spec);
        }

        public async Task AddCartAsync(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCartAsync(Cart cart)
        {
            _context.Carts.Update(cart);
            await _context.SaveChangesAsync();
        }
    }
}
