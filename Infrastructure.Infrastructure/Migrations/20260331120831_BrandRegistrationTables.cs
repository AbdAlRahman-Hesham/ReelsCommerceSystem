using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BrandRegistrationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentStep",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RejectionReasonId",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Brands",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BrandVerification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFrontImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdBackImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelfieImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandVerification_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RejectionReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejectionReasons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user1" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user2" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user4" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user5" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user6" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user7" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user8" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user9" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentStep", "RejectionReasonId", "Status", "UserId" },
                values: new object[] { 0, null, 0, "user10" });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_RejectionReasonId",
                table: "Brands",
                column: "RejectionReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_UserId",
                table: "Brands",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BrandVerification_BrandId",
                table: "BrandVerification",
                column: "BrandId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands",
                column: "RejectionReasonId",
                principalTable: "RejectionReasons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_RejectionReasons_RejectionReasonId",
                table: "Brands");

            migrationBuilder.DropTable(
                name: "BrandVerification");

            migrationBuilder.DropTable(
                name: "RejectionReasons");

            migrationBuilder.DropIndex(
                name: "IX_Brands_RejectionReasonId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_UserId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "CurrentStep",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "RejectionReasonId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Brands");
        }
    }
}
