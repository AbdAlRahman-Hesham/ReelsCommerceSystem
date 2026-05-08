namespace ReelsCommerceSystem.Application.DTOs.Response.DiscountCode;

public class DiscountCodeResDto
{
    public int Id { get; set; }
    public string Code { get; set; } = default!;
    public int UsageCount { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal DiscountValue { get; set; }
}
