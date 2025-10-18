using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class UserSeeding : IEntityTypeConfiguration<User>
{
    private static readonly DateTime _staticSeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    private const string _staticPasswordHash = "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==";

    public void Configure(EntityTypeBuilder<User> builder)
    {
        var users = new List<User>
        {
            new User
            {
                Id = "user1",
                UserName = "john.doe@example.com",
                NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
                Email = "john.doe@example.com",
                NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "John Doe",
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                DateOfBirth = new DateTime(1990, 5, 15),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate,
                Role = Role.Customer,
                SecurityStamp = "A1B2C3D4-E5F6-7890-ABCD-EF1234567890",
                ConcurrencyStamp = "A1B2C3D4-E5F6-7890-ABCD-EF1234567890",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user2",
                UserName = "sarah.smith@example.com",
                NormalizedUserName = "SARAH.SMITH@EXAMPLE.COM",
                Email = "sarah.smith@example.com",
                NormalizedEmail = "SARAH.SMITH@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Sarah Smith",
                FirstName = "Sarah",
                LastName = "Smith",
                Gender = "Female",
                DateOfBirth = new DateTime(1992, 8, 22),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(1),
                Role = Role.Customer,
                SecurityStamp = "B2C3D4E5-F6A7-8901-BCDE-F12345678901",
                ConcurrencyStamp = "B2C3D4E5-F6A7-8901-BCDE-F12345678901",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user3",
                UserName = "mike.johnson@example.com",
                NormalizedUserName = "MIKE.JOHNSON@EXAMPLE.COM",
                Email = "mike.johnson@example.com",
                NormalizedEmail = "MIKE.JOHNSON@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Mike Johnson",
                FirstName = "Mike",
                LastName = "Johnson",
                Gender = "Male",
                DateOfBirth = new DateTime(1988, 3, 10),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(2),
                Role = Role.Customer,
                SecurityStamp = "C3D4E5F6-A7B8-9012-CDEF-123456789012",
                ConcurrencyStamp = "C3D4E5F6-A7B8-9012-CDEF-123456789012",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user4",
                UserName = "emily.davis@example.com",
                NormalizedUserName = "EMILY.DAVIS@EXAMPLE.COM",
                Email = "emily.davis@example.com",
                NormalizedEmail = "EMILY.DAVIS@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Emily Davis",
                FirstName = "Emily",
                LastName = "Davis",
                Gender = "Female",
                DateOfBirth = new DateTime(1995, 11, 5),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(3),
                Role = Role.Customer,
                SecurityStamp = "D4E5F6A7-B8C9-0123-DEF1-234567890123",
                ConcurrencyStamp = "D4E5F6A7-B8C9-0123-DEF1-234567890123",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user5",
                UserName = "david.wilson@example.com",
                NormalizedUserName = "DAVID.WILSON@EXAMPLE.COM",
                Email = "david.wilson@example.com",
                NormalizedEmail = "DAVID.WILSON@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "David Wilson",
                FirstName = "David",
                LastName = "Wilson",
                Gender = "Male",
                DateOfBirth = new DateTime(1991, 7, 18),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(4),
                Role = Role.Customer,
                SecurityStamp = "E5F6A7B8-C9D0-1234-EF12-345678901234",
                ConcurrencyStamp = "E5F6A7B8-C9D0-1234-EF12-345678901234",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user6",
                UserName = "lisa.brown@example.com",
                NormalizedUserName = "LISA.BROWN@EXAMPLE.COM",
                Email = "lisa.brown@example.com",
                NormalizedEmail = "LISA.BROWN@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Lisa Brown",
                FirstName = "Lisa",
                LastName = "Brown",
                Gender = "Female",
                DateOfBirth = new DateTime(1993, 4, 25),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(5),
                Role = Role.Customer,
                SecurityStamp = "F6A7B8C9-D0E1-2345-F123-456789012345",
                ConcurrencyStamp = "F6A7B8C9-D0E1-2345-F123-456789012345",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user7",
                UserName = "james.taylor@example.com",
                NormalizedUserName = "JAMES.TAYLOR@EXAMPLE.COM",
                Email = "james.taylor@example.com",
                NormalizedEmail = "JAMES.TAYLOR@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "James Taylor",
                FirstName = "James",
                LastName = "Taylor",
                Gender = "Male",
                DateOfBirth = new DateTime(1989, 12, 8),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(6),
                Role = Role.Customer,
                SecurityStamp = "A7B8C9D0-E1F2-3456-1234-567890123456",
                ConcurrencyStamp = "A7B8C9D0-E1F2-3456-1234-567890123456",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user8",
                UserName = "anna.martinez@example.com",
                NormalizedUserName = "ANNA.MARTINEZ@EXAMPLE.COM",
                Email = "anna.martinez@example.com",
                NormalizedEmail = "ANNA.MARTINEZ@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Anna Martinez",
                FirstName = "Anna",
                LastName = "Martinez",
                Gender = "Female",
                DateOfBirth = new DateTime(1994, 9, 14),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(7),
                Role = Role.Customer,
                SecurityStamp = "B8C9D0E1-F2A3-4567-2345-678901234567",
                ConcurrencyStamp = "B8C9D0E1-F2A3-4567-2345-678901234567",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user9",
                UserName = "robert.lee@example.com",
                NormalizedUserName = "ROBERT.LEE@EXAMPLE.COM",
                Email = "robert.lee@example.com",
                NormalizedEmail = "ROBERT.LEE@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Robert Lee",
                FirstName = "Robert",
                LastName = "Lee",
                Gender = "Male",
                DateOfBirth = new DateTime(1987, 6, 30),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(8),
                Role = Role.Customer,
                SecurityStamp = "C9D0E1F2-A3B4-5678-3456-789012345678",
                ConcurrencyStamp = "C9D0E1F2-A3B4-5678-3456-789012345678",
                PasswordHash = _staticPasswordHash
            },
            new User
            {
                Id = "user10",
                UserName = "jessica.white@example.com",
                NormalizedUserName = "JESSICA.WHITE@EXAMPLE.COM",
                Email = "jessica.white@example.com",
                NormalizedEmail = "JESSICA.WHITE@EXAMPLE.COM",
                EmailConfirmed = true,
                DisplayName = "Jessica White",
                FirstName = "Jessica",
                LastName = "White",
                Gender = "Female",
                DateOfBirth = new DateTime(1996, 2, 20),
                ImageURL = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg",
                CreatedAt = _staticSeedDate.AddDays(9),
                Role = Role.Customer,
                SecurityStamp = "D0E1F2A3-B4C5-6789-4567-890123456789",
                ConcurrencyStamp = "D0E1F2A3-B4C5-6789-4567-890123456789",
                PasswordHash = _staticPasswordHash
            }
        };

        builder.HasData(users);
    }
}
