namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class FinancialAuditLogDto
{
    public int Id { get; set; }
    public string Action { get; set; } = null!;
    public string EntityType { get; set; } = null!;
    public int EntityId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? PerformedBy { get; set; }
    public string? IpAddress { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}
