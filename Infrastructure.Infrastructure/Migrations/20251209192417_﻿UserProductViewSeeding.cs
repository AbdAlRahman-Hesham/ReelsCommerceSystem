using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _﻿UserProductViewSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserProductView",
                columns: new[] { "Id", "CreatedAt", "ProductId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 2, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 3, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 4, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 5, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 6, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 7, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 8, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 9, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 10, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user4" },
                    { 11, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserProductView",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
