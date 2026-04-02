using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingForRegistrationReasonsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RejectionReasons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "RejectionReasons",
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "INVALID_DOCS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submitted documents are not valid or unclear", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "FAKE_BRAND", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brand information seems fake or misleading", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "INCOMPLETE_PROFILE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brand profile is missing required information", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "POLICY_VIOLATION", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Violates platform policies", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RejectionReasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RejectionReasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RejectionReasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RejectionReasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RejectionReasons");
        }
    }
}
