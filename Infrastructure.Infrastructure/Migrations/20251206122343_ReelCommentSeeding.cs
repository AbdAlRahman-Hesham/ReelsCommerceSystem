using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReelCommentSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReelComment",
                columns: new[] { "Id", "Content", "CreatedAt", "ReelId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "This product looks amazing! 🔥🔥", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 2, "I love this brand! 😍", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 3, "Where can I buy this?", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 4, "Great quality! Highly recommended 💯", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user6" },
                    { 5, "Looks nice but is it available in Egypt?", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReelComment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReelComment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReelComment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReelComment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReelComment",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
