using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditReelstatusThumbnailUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Reels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Reels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Status", "ThumbnailUrl" },
                values: new object[] { 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reels");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Reels");
        }
    }
}
