using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalBrandRegistrationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: 2);
        }
    }
}
