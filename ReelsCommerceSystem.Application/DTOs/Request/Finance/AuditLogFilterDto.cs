namespace ReelsCommerceSystem.Application.DTOs.Request.Finance;

public class AuditLogFilterDto
{
    public string? ActionType { get; set; }
    public string? EntityType { get; set; }
    public string? PerformedBy { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}
