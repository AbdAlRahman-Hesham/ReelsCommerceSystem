using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.ChatEntities;

public class ChatRoom
{
    public int Id { get; set; }
    
    public string User1Id { get; set; } = default!;
    public virtual User User1 { get; set; } = default!;
    
    public string User2Id { get; set; } = default!;
    public virtual User User2 { get; set; } = default!;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
