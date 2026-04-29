using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.ChatEntities;

public class ChatRoom :BaseEntity
{
    
    public string User1Id { get; set; } = default!;
    public virtual User User1 { get; set; } = default!;
    
    public string User2Id { get; set; } = default!;
    public virtual User User2 { get; set; } = default!;
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
