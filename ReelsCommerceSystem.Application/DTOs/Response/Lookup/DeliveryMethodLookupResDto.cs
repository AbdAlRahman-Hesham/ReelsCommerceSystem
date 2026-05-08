namespace ReelsCommerceSystem.Application.DTOs.Response.Lookup;

public class DeliveryMethodLookupResDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? ArName { get; set; }
    public decimal Price { get; set; }
}
