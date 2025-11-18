using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductColorSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductColor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 10,
                column: "Quantity",
                value: 0);

            migrationBuilder.InsertData(
                table: "ProductColorMapping",
                columns: new[] { "Id", "ProductColorId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, 1, 48 },
                    { 2, 5, 1, 42 },
                    { 3, 3, 1, 30 },
                    { 4, 2, 2, 40 },
                    { 5, 4, 2, 24 },
                    { 6, 1, 2, 16 },
                    { 7, 4, 3, 52 },
                    { 8, 2, 3, 45 },
                    { 9, 5, 3, 30 },
                    { 10, 1, 3, 23 },
                    { 11, 3, 4, 40 },
                    { 12, 5, 4, 35 },
                    { 13, 10, 4, 25 },
                    { 14, 4, 5, 90 },
                    { 15, 5, 5, 60 },
                    { 16, 3, 5, 50 },
                    { 17, 10, 6, 36 },
                    { 18, 4, 6, 31 },
                    { 19, 2, 6, 23 },
                    { 20, 4, 7, 120 },
                    { 21, 2, 7, 90 },
                    { 22, 5, 7, 90 },
                    { 23, 4, 8, 60 },
                    { 24, 10, 8, 36 },
                    { 25, 5, 8, 24 },
                    { 26, 4, 9, 90 },
                    { 27, 2, 9, 60 },
                    { 28, 7, 9, 50 },
                    { 29, 4, 10, 75 },
                    { 30, 10, 10, 45 },
                    { 31, 5, 10, 30 },
                    { 32, 4, 11, 32 },
                    { 33, 2, 11, 28 },
                    { 34, 1, 11, 20 },
                    { 35, 4, 12, 63 },
                    { 36, 7, 12, 45 },
                    { 37, 9, 12, 36 },
                    { 38, 2, 12, 36 },
                    { 39, 5, 13, 72 },
                    { 40, 9, 13, 48 },
                    { 41, 5, 14, 140 },
                    { 42, 3, 14, 60 },
                    { 43, 5, 15, 75 },
                    { 44, 2, 15, 45 },
                    { 45, 7, 15, 30 },
                    { 46, 5, 16, 60 },
                    { 47, 9, 16, 40 },
                    { 48, 5, 17, 99 },
                    { 49, 6, 17, 81 },
                    { 50, 5, 18, 104 },
                    { 51, 9, 18, 56 },
                    { 52, 4, 19, 48 },
                    { 53, 10, 19, 42 },
                    { 54, 1, 19, 30 },
                    { 55, 4, 20, 45 },
                    { 56, 10, 20, 30 },
                    { 57, 2, 20, 25 },
                    { 58, 4, 21, 52 },
                    { 59, 1, 21, 37 },
                    { 60, 2, 21, 30 },
                    { 61, 6, 21, 31 },
                    { 62, 2, 22, 32 },
                    { 63, 4, 22, 28 },
                    { 64, 1, 22, 20 },
                    { 65, 4, 23, 100 },
                    { 66, 2, 23, 60 },
                    { 67, 1, 23, 40 },
                    { 68, 4, 24, 56 },
                    { 69, 5, 24, 49 },
                    { 70, 10, 24, 35 },
                    { 71, 3, 25, 44 },
                    { 72, 5, 25, 38 },
                    { 73, 10, 25, 28 },
                    { 74, 5, 26, 75 },
                    { 75, 7, 26, 45 },
                    { 76, 9, 26, 30 },
                    { 77, 5, 27, 81 },
                    { 78, 7, 27, 54 },
                    { 79, 9, 27, 45 },
                    { 80, 3, 28, 56 },
                    { 81, 5, 28, 56 },
                    { 82, 2, 28, 48 },
                    { 83, 5, 29, 120 },
                    { 84, 3, 29, 80 },
                    { 85, 5, 30, 99 },
                    { 86, 7, 30, 81 },
                    { 87, 4, 31, 52 },
                    { 88, 2, 31, 45 },
                    { 89, 1, 31, 33 },
                    { 90, 4, 32, 45 },
                    { 91, 10, 32, 27 },
                    { 92, 5, 32, 18 },
                    { 93, 4, 33, 45 },
                    { 94, 1, 33, 30 },
                    { 95, 2, 33, 25 },
                    { 96, 3, 34, 56 },
                    { 97, 4, 34, 49 },
                    { 98, 5, 34, 35 },
                    { 99, 2, 35, 64 },
                    { 100, 4, 35, 56 },
                    { 101, 5, 35, 40 },
                    { 102, 4, 36, 70 },
                    { 103, 2, 36, 50 },
                    { 104, 1, 36, 40 },
                    { 105, 6, 36, 40 },
                    { 106, 3, 37, 44 },
                    { 107, 5, 37, 38 },
                    { 108, 10, 37, 28 },
                    { 109, 3, 38, 35 },
                    { 110, 5, 38, 30 },
                    { 111, 2, 38, 20 },
                    { 112, 7, 38, 15 },
                    { 113, 3, 39, 81 },
                    { 114, 5, 39, 54 },
                    { 115, 10, 39, 45 },
                    { 116, 5, 40, 75 },
                    { 117, 3, 40, 45 },
                    { 118, 8, 40, 30 },
                    { 119, 5, 41, 54 },
                    { 120, 10, 41, 36 },
                    { 121, 3, 42, 80 },
                    { 122, 5, 42, 70 },
                    { 123, 10, 42, 50 },
                    { 124, 4, 43, 67 },
                    { 125, 2, 43, 45 },
                    { 126, 5, 43, 38 },
                    { 127, 4, 44, 72 },
                    { 128, 10, 44, 54 },
                    { 129, 2, 44, 27 },
                    { 130, 1, 44, 27 },
                    { 131, 4, 45, 110 },
                    { 132, 10, 45, 66 },
                    { 133, 5, 45, 44 },
                    { 134, 4, 46, 56 },
                    { 135, 7, 46, 35 },
                    { 136, 9, 46, 28 },
                    { 137, 2, 46, 21 },
                    { 138, 4, 47, 50 },
                    { 139, 2, 47, 40 },
                    { 140, 1, 47, 40 },
                    { 141, 6, 47, 36 },
                    { 142, 3, 47, 34 },
                    { 143, 10, 48, 58 },
                    { 144, 4, 48, 45 },
                    { 145, 5, 48, 27 },
                    { 146, 5, 49, 96 },
                    { 147, 3, 49, 64 },
                    { 148, 5, 50, 77 },
                    { 149, 9, 50, 63 },
                    { 150, 3, 51, 60 },
                    { 151, 5, 51, 52 },
                    { 152, 10, 51, 38 },
                    { 153, 5, 52, 65 },
                    { 154, 7, 52, 39 },
                    { 155, 9, 52, 26 },
                    { 156, 5, 53, 72 },
                    { 157, 9, 53, 48 },
                    { 158, 5, 54, 88 },
                    { 159, 2, 54, 72 },
                    { 160, 7, 55, 31 },
                    { 161, 4, 55, 27 },
                    { 162, 1, 55, 18 },
                    { 163, 9, 55, 14 },
                    { 164, 6, 56, 32 },
                    { 165, 8, 56, 28 },
                    { 166, 1, 56, 20 },
                    { 167, 4, 57, 36 },
                    { 168, 7, 57, 30 },
                    { 169, 2, 57, 24 },
                    { 170, 6, 57, 18 },
                    { 171, 1, 57, 12 },
                    { 172, 4, 58, 35 },
                    { 173, 7, 58, 21 },
                    { 174, 9, 58, 14 },
                    { 175, 1, 59, 45 },
                    { 176, 4, 59, 37 },
                    { 177, 2, 59, 30 },
                    { 178, 7, 59, 22 },
                    { 179, 9, 59, 16 },
                    { 180, 4, 60, 90 },
                    { 181, 10, 60, 60 },
                    { 182, 7, 60, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductColorMapping",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductColor");
        }
    }
}
