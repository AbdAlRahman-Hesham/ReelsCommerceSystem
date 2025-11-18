using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvailableColors",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HaveOffer",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AvailableSize",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AvailableColors", "HaveOffer", "AvailableSize", "Status" },
                values: new object[] { null, false, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableColors",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HaveOffer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AvailableSize",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Products");
        }
    }
}
