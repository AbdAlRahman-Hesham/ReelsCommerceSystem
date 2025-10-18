using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingBrandReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageURL", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "A1B2C3D4-E5F6-7890-ABCD-EF1234567890", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "john.doe@example.com", true, "John", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "A1B2C3D4-E5F6-7890-ABCD-EF1234567890", false, "john.doe@example.com" },
                    { "user10", 0, "D0E1F2A3-B4C5-6789-4567-890123456789", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1996, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica White", "jessica.white@example.com", true, "Jessica", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "White", false, null, "JESSICA.WHITE@EXAMPLE.COM", "JESSICA.WHITE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "D0E1F2A3-B4C5-6789-4567-890123456789", false, "jessica.white@example.com" },
                    { "user2", 0, "B2C3D4E5-F6A7-8901-BCDE-F12345678901", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1992, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Smith", "sarah.smith@example.com", true, "Sarah", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Smith", false, null, "SARAH.SMITH@EXAMPLE.COM", "SARAH.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "B2C3D4E5-F6A7-8901-BCDE-F12345678901", false, "sarah.smith@example.com" },
                    { "user3", 0, "C3D4E5F6-A7B8-9012-CDEF-123456789012", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1988, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike Johnson", "mike.johnson@example.com", true, "Mike", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Johnson", false, null, "MIKE.JOHNSON@EXAMPLE.COM", "MIKE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "C3D4E5F6-A7B8-9012-CDEF-123456789012", false, "mike.johnson@example.com" },
                    { "user4", 0, "D4E5F6A7-B8C9-0123-DEF1-234567890123", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", "emily.davis@example.com", true, "Emily", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Davis", false, null, "EMILY.DAVIS@EXAMPLE.COM", "EMILY.DAVIS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "D4E5F6A7-B8C9-0123-DEF1-234567890123", false, "emily.davis@example.com" },
                    { "user5", 0, "E5F6A7B8-C9D0-1234-EF12-345678901234", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1991, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Wilson", "david.wilson@example.com", true, "David", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Wilson", false, null, "DAVID.WILSON@EXAMPLE.COM", "DAVID.WILSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "E5F6A7B8-C9D0-1234-EF12-345678901234", false, "david.wilson@example.com" },
                    { "user6", 0, "F6A7B8C9-D0E1-2345-F123-456789012345", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa Brown", "lisa.brown@example.com", true, "Lisa", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Brown", false, null, "LISA.BROWN@EXAMPLE.COM", "LISA.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "F6A7B8C9-D0E1-2345-F123-456789012345", false, "lisa.brown@example.com" },
                    { "user7", 0, "A7B8C9D0-E1F2-3456-1234-567890123456", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1989, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Taylor", "james.taylor@example.com", true, "James", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Taylor", false, null, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "A7B8C9D0-E1F2-3456-1234-567890123456", false, "james.taylor@example.com" },
                    { "user8", 0, "B8C9D0E1-F2A3-4567-2345-678901234567", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Martinez", "anna.martinez@example.com", true, "Anna", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Martinez", false, null, "ANNA.MARTINEZ@EXAMPLE.COM", "ANNA.MARTINEZ@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "B8C9D0E1-F2A3-4567-2345-678901234567", false, "anna.martinez@example.com" },
                    { "user9", 0, "C9D0E1F2-A3B4-5678-3456-789012345678", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Lee", "robert.lee@example.com", true, "Robert", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Lee", false, null, "ROBERT.LEE@EXAMPLE.COM", "ROBERT.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "C9D0E1F2-A3B4-5678-3456-789012345678", false, "robert.lee@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BrandReview",
                columns: new[] { "Id", "BrandId", "Comment", "CreatedAt", "Rating", "UserId", "numOfDislikes", "numOfLikes" },
                values: new object[,]
                {
                    { 1, 1, "Love their sustainable approach! The quality is amazing and the materials feel premium. Definitely worth the price.", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user1", 1, 25 },
                    { 2, 1, "Good products but shipping took longer than expected. The eco-friendly packaging was a nice touch though.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user2", 2, 12 },
                    { 3, 1, "The clothes are comfortable and stylish. Happy to support a brand that cares about the environment.", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user3", 0, 18 },
                    { 4, 2, "Their charging dock is a game-changer! Charges all my devices simultaneously without overheating.", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user4", 0, 32 },
                    { 5, 2, "Decent products but customer service could be better. Had an issue with my order resolution.", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), 3, "user5", 3, 8 },
                    { 6, 2, "The smart accessories are innovative and well-designed. Perfect for my tech-heavy lifestyle.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user6", 1, 15 },
                    { 7, 3, "The serum transformed my skin! Natural ingredients actually work. My skin has never looked better.", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user7", 0, 28 },
                    { 8, 3, "Products are good but a bit pricey for the quantity. The results are noticeable though.", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user8", 1, 10 },
                    { 9, 3, "Had an allergic reaction to one product. Customer service was helpful with the return.", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc), 2, "user9", 5, 3 },
                    { 10, 4, "Best streetwear brand out there! The hoodies are super comfortable and the designs are unique.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user10", 1, 35 },
                    { 11, 4, "Quality is good but sizes run small. Make sure to order a size up for the perfect fit.", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user1", 2, 14 },
                    { 12, 4, "Love their style! The jackets are my favorite - perfect for urban fashion enthusiasts.", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user2", 0, 22 },
                    { 13, 5, "The yoga mat is incredible! Non-slip and eco-friendly. My practice has improved significantly.", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user3", 0, 30 },
                    { 14, 5, "Their wellness products create such a calming atmosphere at home. The diffuser is a must-have.", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user4", 1, 12 },
                    { 15, 5, "Good quality products but the scent options are limited. Would love to see more variety.", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 3, "user5", 2, 6 },
                    { 16, 6, "The fitness tracker is accurate and durable. Battery life exceeds expectations.", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user6", 0, 27 },
                    { 17, 6, "Smart dumbbells are innovative but the app connectivity can be glitchy sometimes.", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 3, "user7", 4, 5 },
                    { 18, 6, "Great fitness equipment for home workouts. The chest strap provides accurate heart rate data.", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user8", 1, 11 },
                    { 19, 7, "Love their eco-friendly approach! The air filter has improved our home air quality noticeably.", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user9", 0, 29 },
                    { 20, 7, "Sustainable products that actually work. The bamboo lamp is both functional and beautiful.", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user10", 1, 16 },
                    { 21, 7, "Good concept but some products feel overpriced for what they offer.", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 3, "user1", 3, 7 },
                    { 22, 8, "Their tech accessories are top-notch! The charger is fast and reliable for all my devices.", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user2", 1, 31 },
                    { 23, 8, "Great mouse design but the battery life could be better. Comfortable for long work sessions.", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user3", 2, 13 },
                    { 24, 8, "The earbuds have clear sound quality. Perfect for both calls and music.", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user4", 0, 17 },
                    { 25, 9, "My skin has never been happier! The cleanser is gentle yet effective. Love the ethical approach.", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user5", 0, 26 },
                    { 26, 9, "Good skincare line but the moisturizer could be more hydrating for dry skin types.", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 3, "user6", 2, 4 },
                    { 27, 9, "The night cream works wonders! Woke up with glowing skin after just one use.", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user7", 1, 24 },
                    { 28, 10, "Fashion-forward pieces that always get compliments! The dress quality is exceptional.", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user8", 0, 33 },
                    { 29, 10, "Trendy designs but some items sell out too quickly. Wish they had better stock management.", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "user9", 1, 11 },
                    { 30, 10, "Love their unique style! The handbag is my new favorite accessory for every occasion.", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), 5, "user10", 0, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "user9");
        }
    }
}
