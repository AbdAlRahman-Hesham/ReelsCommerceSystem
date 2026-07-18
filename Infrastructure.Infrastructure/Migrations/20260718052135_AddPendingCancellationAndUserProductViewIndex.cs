using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPendingCancellationAndUserProductViewIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserProductView_UserId",
                table: "UserProductView");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "OrderTrackings",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(682), new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(4412), new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(4427), new DateTime(2026, 7, 18, 5, 21, 6, 307, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 386, DateTimeKind.Utc).AddTicks(8714), new DateTime(2026, 7, 18, 5, 21, 6, 386, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3413), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3442), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3453), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3464), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3473), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3483), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3494), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3691), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3702), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3712), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3722), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3732), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3742), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3757), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3767), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3777), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3909), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3921), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3931), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3942), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3952), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3962), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3972), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3983), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3994), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4004), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4012), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4022), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4032), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4041), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4050), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4059), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4180), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4191), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4200), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4210), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4219), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4231), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4241), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4250), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4260), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4279), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4289), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4297), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4307), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4316), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4326), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4336), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4346), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4356), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4366), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4375), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4384), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4393), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4403), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4413), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4421), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4430), new DateTime(2026, 7, 18, 5, 21, 6, 387, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 468, DateTimeKind.Utc).AddTicks(9665), new DateTime(2026, 7, 18, 5, 21, 6, 468, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4560), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4608), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4626), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4755), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4778), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4794), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4811), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4997), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5013), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5029), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5047), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5063), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5078), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5100), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5117), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5134), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5149), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5164), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5325), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5353), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5370), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5389), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5410), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5428), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5445), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5463), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5480), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5495), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5509), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5523), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5634), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5653), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5668), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5722), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5738), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5753), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5769), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5785), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5802), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5818), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5834), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5939), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5957), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5974), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5992), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6009), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6024), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6039), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6089), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6111), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6128), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6147), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6162), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6177), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6194), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6210), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6225), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6240), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6255), new DateTime(2026, 7, 18, 5, 21, 6, 473, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.CreateIndex(
                name: "IX_UserProductView_UserId_ProductId",
                table: "UserProductView",
                columns: new[] { "UserId", "ProductId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserProductView_UserId_ProductId",
                table: "UserProductView");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "OrderTrackings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(1744), new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2285), new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2287), new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(2725), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3440), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3445), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3448), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3450), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3451), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3453), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3455), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3456), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3458), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3460), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3461), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3463), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3464), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3466), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3467), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3469), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3470), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3472), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3474), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3476), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3496), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3498), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3499), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3532), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3534), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3535), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3537), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3538), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3540), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3542), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3543), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3545), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3546), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3548), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3550), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3551), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3553), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3554), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3557), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3558), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3560), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3561), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3563), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3564), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3566), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3568), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3569), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3571), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3573), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3574), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3576), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3577), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3579), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3580), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3582), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3583), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3585), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 160, DateTimeKind.Utc).AddTicks(7127), new DateTime(2026, 7, 18, 0, 23, 25, 160, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(207), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(213), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(217), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(220), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(255), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(258), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(262), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(265), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(268), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(272), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(274), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(277), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(280), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(284), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(303), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(328), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(331), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(334), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(337), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(340), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(344), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(347), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(350), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(352), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(356), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(359), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(362), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(385), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(388), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(397), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(400), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(404), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(407), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(410), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(413), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(415), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(419), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(422), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(444), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(447), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(450), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(453), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(456), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(460), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(469), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(472), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(475), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(478), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(481), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(484), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(487), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(491), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(493), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(496), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(499), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(502), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(506), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(509), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(512), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.CreateIndex(
                name: "IX_UserProductView_UserId",
                table: "UserProductView",
                column: "UserId");
        }
    }
}
