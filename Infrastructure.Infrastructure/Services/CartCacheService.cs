using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.CartEntities;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class CartCacheService: ICartCacheService
{
    private readonly IMemoryCache _cache;
    private readonly TimeSpan _cacheDuration = TimeSpan.FromDays(7);

    public CartCacheService(IMemoryCache cache)
    {
        _cache = cache;
    }

    private string GetCacheKey(string userId) => $"Cart_{userId}";

    public Cart? GetCart(string userId)
    {
        _cache.TryGetValue(GetCacheKey(userId), out Cart cart);
        return cart;
    }

    public void SaveCart(string userId, Cart cart)
    {
        _cache.Set(GetCacheKey(userId), cart, _cacheDuration);
    }

    public void ClearCart(string userId)
    {
        _cache.Remove(GetCacheKey(userId));
    }
}
