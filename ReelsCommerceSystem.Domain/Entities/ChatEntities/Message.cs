using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ChatEntities;

public class Message : BaseEntity
{
    public int Id { get; set; }

    public int RoomId { get; set; }
    public virtual ChatRoom Room { get; set; } = default!;

    public string SenderId { get; set; } = default!;
    public virtual User Sender { get; set; } = default!;

    public string? Text { get; set; }
    public string? ImageUrl { get; set; }

    public MessageStatus Status { get; set; } = MessageStatus.Pending;
}