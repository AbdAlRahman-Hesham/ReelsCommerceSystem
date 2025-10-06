namespace ReelsCommerceSystem.Application.DTOs.Response.Identity;

public class LoginResDto
{
    public string Token { get; set; } = default!;
    public DateTime ExpiresAt { get; set; }

}
