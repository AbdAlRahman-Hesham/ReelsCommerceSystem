using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.UserEntities
{
    public class Notification : BaseEntity
    {
        [Required]
        public string UserId { get; set; }   

        
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public NotificationType Type { get; set; }  

        public int ReferenceId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }

        [Required]
        [MaxLength(500)]
        public string MessageAr { get; set; }

        public bool IsRead { get; set; } = false;


    }

}
