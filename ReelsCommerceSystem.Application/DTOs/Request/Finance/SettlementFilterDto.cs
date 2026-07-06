using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Request.Finance;

public class SettlementFilterDto
{
    public SettlementStatus? Status { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}
