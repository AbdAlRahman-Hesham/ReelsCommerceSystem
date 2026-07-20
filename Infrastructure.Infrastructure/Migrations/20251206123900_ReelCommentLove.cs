using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReelCommentLove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReelCommentLove",
                columns: new[] { "Id", "CreatedAt", "ReelCommentId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 2, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 3, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 4, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "user8" },
                    { 5, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "user1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReelCommentLove",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReelCommentLove",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReelCommentLove",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReelCommentLove",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReelCommentLove",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
