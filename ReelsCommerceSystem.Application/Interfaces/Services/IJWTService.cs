using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IJwtService
{
    Task<string> CreateTokenAsync(User user);    
}