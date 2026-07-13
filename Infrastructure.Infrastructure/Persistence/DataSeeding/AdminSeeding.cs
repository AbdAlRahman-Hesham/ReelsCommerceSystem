using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.UserEntities;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class AdminSeeding : IEntityTypeConfiguration<User>
    {

        private const string AdminPasswordHash =
       "AQAAAAEAACcQAAAAEIpyyMPcNeei3/WytkEumEu2aMbVRzav8jHAPUvwYnmuPbO9YJIpj1xMATiocNF4cQ==";

        private const string SecurityStamp = "STATIC-SECURITY-STAMP";
        private const string ConcurrencyStamp = "STATIC-CONCURRENCY-STAMP";
        private static readonly DateTime _staticSeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admins = new List<User>
        {
            CreateAdmin("1", "Abdalrahman", "Abdalrahman@alluvo.life"),
            CreateAdmin("2", "Abdallah", "Abdallah@alluvo.life"),
            CreateAdmin("3", "Esraa", "Esraa@alluvo.life"),
            CreateAdmin("4", "Ashrakat", "Ashrakat@alluvo.life"),
            CreateAdmin("5", "Mariam", "Mariam@alluvo.life"),
            CreateAdmin("6", "Nada", "Nada@alluvo.life"),
            CreateAdmin("7", "Tasneem", "Tasneem@alluvo.life"),
            CreateAdmin("8", "Abdaljawad", "Abdaljawad@alluvo.life"),
            CreateAdmin("9", "Suzan", "Suzan@alluvo.life"),
            CreateAdmin("10", "Aya", "Aya@alluvo.life"),
        };

            builder.HasData(admins);
        }

        private User CreateAdmin(string id, string name, string email)
        {
            return new User
            {
                Id = id,
                UserName = name,
                NormalizedUserName = name.ToUpper(),
                Email = email,
                NormalizedEmail = email.ToUpper(),
                EmailConfirmed = true,

                DisplayName = name,
                FirstName = name,
                LastName = "Admin",

                CreatedAt = _staticSeedDate,

                PasswordHash = AdminPasswordHash,
                SecurityStamp = SecurityStamp,
                ConcurrencyStamp = ConcurrencyStamp
            };
    }
    }
}
