using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.TikTok;

public class TikTokExchangeReq
{
    [Required]
    public string Code { get; set; } = string.Empty;
    [Required]
    public string State { get; set; } = string.Empty;
}