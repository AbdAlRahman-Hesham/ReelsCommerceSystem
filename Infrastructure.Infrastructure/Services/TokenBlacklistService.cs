using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class TokenBlacklistService : ITokenBlacklistService
{
    private readonly IMemoryCache _cache;
    private readonly MemoryCacheEntryOptions _cacheOptions;
    private const string CacheKey = "BlacklistedTokens";

    public TokenBlacklistService(IMemoryCache cache)
    {
        _cache = cache;

        _cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(10)
        };

        // Initialize list if not exists
        if (!_cache.TryGetValue(CacheKey, out HashSet<string> _))
        {
            _cache.Set(CacheKey, new HashSet<string>(), _cacheOptions);
        }
    }

    public Task AddAsync(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            return Task.CompletedTask;

        token = token.StartsWith("Bearer ") ? token[7..].Trim() : token.Trim();

        var set = _cache.Get<HashSet<string>>(CacheKey)!;

        lock (set)
        {
            set.Add(token);

            // Re-set to refresh expiration timer
            _cache.Set(CacheKey, set, _cacheOptions);
        }

        return Task.CompletedTask;
    }

    public Task<bool> IsBlacklistedAsync(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            return Task.FromResult(true);

        token = token.StartsWith("Bearer ") ? token[7..].Trim() : token.Trim();

        var set = _cache.Get<HashSet<string>>(CacheKey)!;

        lock (set)
        {
            return Task.FromResult(set.Contains(token));
        }
    }
}
