using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.AiChatsEntities
{
    public class AiChat:BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ChatHistory { get; set; } = null!;   
        public string GeneratedImages { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
