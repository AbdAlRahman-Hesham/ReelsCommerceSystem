using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Chatpec
{
    public class GetMessageSpec : Specification<Message>
    {
        public GetMessageSpec(
            int roomId,
            string userId,
            bool unreadOnly,
            string? afterMessageId,
            int pageIndex,
            int pageSize)
            : base(
                criteria: BuildCriteria(roomId, userId, unreadOnly, afterMessageId),
                orderBy: m => m.Id,
                sortOrder: XmlSortOrder.Descending,
                pageIndex: pageIndex,
                pageSize: pageSize)
        {
        }

        private static Expression<Func<Message, bool>> BuildCriteria(
            int roomId,
            string userId,
            bool unreadOnly,
            string? afterMessageId)
        {
            int? afterId = null;

            if (!string.IsNullOrEmpty(afterMessageId))
            {
                var cleaned = Uri.UnescapeDataString(afterMessageId);
                var decrypted = EncryptionHelper.Decrypt(cleaned);

                if (!int.TryParse(decrypted, out var id))
                    throw new Exception("Invalid afterMessageId");

                afterId = id;
            }

            return m =>
                m.RoomId == roomId &&

                (!unreadOnly ||
                    (m.SenderId != userId &&
                     m.Status != MessageStatus.Seen)) &&

                // 🔥 المهم هنا
                (!afterId.HasValue || m.Id > afterId.Value);
        }
    }
}