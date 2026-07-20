using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ShippingCompanySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "ShippingCompanies",
                columns: new[] { "Id", "ContactEmail", "ContactPhone", "CreatedAt", "IsActive", "Name", "UpdatedAt", "UserId" },
                values: new object[] { 1, "shipping@reelscommerce.com", "01000000001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Default Shipping Company", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShippingCompanies",
                keyColumn: "Id",
                keyValue: 1);

         }
    }
}
