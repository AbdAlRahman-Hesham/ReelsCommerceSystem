namespace ReelsCommerceSystem.Domain.Entities.UserEntities;

public class Address
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Postcode { get; set; } = null!;
    public string Country { get; set; } = default!;
    public string Street { get; set; } = default!;
    public string City { get; set; } = default!;
    public User user { get; set; } = default!;
    public string UserId { get; set; } = default!;

}