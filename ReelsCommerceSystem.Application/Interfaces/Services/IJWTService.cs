namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IJwtService
{
    public string GenerateToken(string userId, string email);
}