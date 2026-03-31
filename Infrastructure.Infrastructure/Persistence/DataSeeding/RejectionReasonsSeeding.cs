using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class RejectionReasonsSeeding : IEntityTypeConfiguration<RejectionReason>
    {
        public void Configure(EntityTypeBuilder<RejectionReason> builder)
        {
            builder.HasData([
                new(){Id = 1, Code = "INVALID_DOCS", Description = "Submitted documents are not valid or unclear",CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = new DateTime(2024, 1, 1)},
                new(){Id = 2, Code = "FAKE_BRAND",   Description = "Brand information seems fake or misleading",CreatedAt = new DateTime(2024, 1, 1),UpdatedAt = new DateTime(2024, 1, 1)},
                new(){Id = 3, Code = "INCOMPLETE_PROFILE",   Description = "Brand profile is missing required information",CreatedAt = new DateTime(2024, 1, 1),UpdatedAt = new DateTime(2024, 1, 1)},
                new(){Id = 4, Code = "POLICY_VIOLATION",Description = "Violates platform policies",CreatedAt = new DateTime(2024, 1, 1),UpdatedAt = new DateTime(2024, 1, 1)}
                ]);
        }
    }
}
