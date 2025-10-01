namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IJWTService
{
    public string GenerateToken(string userId, string email);
}