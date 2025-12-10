using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingForReplyComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReelCommentReplies",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentCommentId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Totally agree with you! 🔥", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 2, "Same question! 😂", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user7" },
                    { 3, "Yes available worldwide 🌍", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user4" },
                    { 4, "High quality indeed 💯", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReelCommentReplies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReelCommentReplies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReelCommentReplies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReelCommentReplies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
