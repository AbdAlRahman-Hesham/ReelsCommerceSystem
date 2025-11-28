using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductColorMappingSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductColorMapping",
                columns: new[] { "Id", "ProductColorId", "ProductId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 5, 1 },
                    { 3, 3, 1 },
                    { 4, 2, 2 },
                    { 5, 4, 2 },
                    { 6, 1, 2 },
                    { 7, 4, 3 },
                    { 8, 2, 3 },
                    { 9, 5, 3 },
                    { 10, 1, 3 },
                    { 11, 3, 4 },
                    { 12, 5, 4 },
                    { 13, 10, 4 },
                    { 14, 4, 5 },
                    { 15, 5, 5 },
                    { 16, 3, 5 },
                    { 17, 10, 6 },
                    { 18, 4, 6 },
                    { 19, 2, 6 },
                    { 20, 4, 7 },
                    { 21, 2, 7 },
                    { 22, 5, 7 },
                    { 23, 4, 8 },
                    { 24, 10, 8 },
                    { 25, 5, 8 },
                    { 26, 4, 9 },
                    { 27, 2, 9 },
                    { 28, 7, 9 },
                    { 29, 4, 10 },
                    { 30, 10, 10 },
                    { 31, 5, 10 },
                    { 32, 4, 11 },
                    { 33, 2, 11 },
                    { 34, 1, 11 },
                    { 35, 4, 12 },
                    { 36, 7, 12 },
                    { 37, 9, 12 },
                    { 38, 2, 12 },
                    { 39, 5, 13 },
                    { 40, 9, 13 },
                    { 41, 5, 14 },
                    { 42, 3, 14 },
                    { 43, 5, 15 },
                    { 44, 2, 15 },
                    { 45, 7, 15 },
                    { 46, 5, 16 },
                    { 47, 9, 16 },
                    { 48, 5, 17 },
                    { 49, 6, 17 },
                    { 50, 5, 18 },
                    { 51, 9, 18 },
                    { 52, 4, 19 },
                    { 53, 10, 19 },
                    { 54, 1, 19 },
                    { 55, 4, 20 },
                    { 56, 10, 20 },
                    { 57, 2, 20 },
                    { 58, 4, 21 },
                    { 59, 1, 21 },
                    { 60, 2, 21 },
                    { 61, 6, 21 },
                    { 62, 2, 22 },
                    { 63, 4, 22 },
                    { 64, 1, 22 },
                    { 65, 4, 23 },
                    { 66, 2, 23 },
                    { 67, 1, 23 },
                    { 68, 4, 24 },
                    { 69, 5, 24 },
                    { 70, 10, 24 },
                    { 71, 3, 25 },
                    { 72, 5, 25 },
                    { 73, 10, 25 },
                    { 74, 5, 26 },
                    { 75, 7, 26 },
                    { 76, 9, 26 },
                    { 77, 5, 27 },
                    { 78, 7, 27 },
                    { 79, 9, 27 },
                    { 80, 3, 28 },
                    { 81, 5, 28 },
                    { 82, 2, 28 },
                    { 83, 5, 29 },
                    { 84, 3, 29 },
                    { 85, 5, 30 },
                    { 86, 7, 30 },
                    { 87, 4, 31 },
                    { 88, 2, 31 },
                    { 89, 1, 31 },
                    { 90, 4, 32 },
                    { 91, 10, 32 },
                    { 92, 5, 32 },
                    { 93, 4, 33 },
                    { 94, 1, 33 },
                    { 95, 2, 33 },
                    { 96, 3, 34 },
                    { 97, 4, 34 },
                    { 98, 5, 34 },
                    { 99, 2, 35 },
                    { 100, 4, 35 },
                    { 101, 5, 35 },
                    { 102, 4, 36 },
                    { 103, 2, 36 },
                    { 104, 1, 36 },
                    { 105, 6, 36 },
                    { 106, 3, 37 },
                    { 107, 5, 37 },
                    { 108, 10, 37 },
                    { 109, 3, 38 },
                    { 110, 5, 38 },
                    { 111, 2, 38 },
                    { 112, 7, 38 },
                    { 113, 3, 39 },
                    { 114, 5, 39 },
                    { 115, 10, 39 },
                    { 116, 5, 40 },
                    { 117, 3, 40 },
                    { 118, 8, 40 },
                    { 119, 5, 41 },
                    { 120, 10, 41 },
                    { 121, 3, 42 },
                    { 122, 5, 42 },
                    { 123, 10, 42 },
                    { 124, 4, 43 },
                    { 125, 2, 43 },
                    { 126, 5, 43 },
                    { 127, 4, 44 },
                    { 128, 10, 44 },
                    { 129, 2, 44 },
                    { 130, 1, 44 },
                    { 131, 4, 45 },
                    { 132, 10, 45 },
                    { 133, 5, 45 },
                    { 134, 4, 46 },
                    { 135, 7, 46 },
                    { 136, 9, 46 },
                    { 137, 2, 46 },
                    { 138, 4, 47 },
                    { 139, 2, 47 },
                    { 140, 1, 47 },
                    { 141, 6, 47 },
                    { 142, 3, 47 },
                    { 143, 10, 48 },
                    { 144, 4, 48 },
                    { 145, 5, 48 },
                    { 146, 5, 49 },
                    { 147, 3, 49 },
                    { 148, 5, 50 },
                    { 149, 9, 50 },
                    { 150, 3, 51 },
                    { 151, 5, 51 },
                    { 152, 10, 51 },
                    { 153, 5, 52 },
                    { 154, 7, 52 },
                    { 155, 9, 52 },
                    { 156, 5, 53 },
                    { 157, 9, 53 },
                    { 158, 5, 54 },
                    { 159, 2, 54 },
                    { 160, 7, 55 },
                    { 161, 4, 55 },
                    { 162, 1, 55 },
                    { 163, 9, 55 },
                    { 164, 6, 56 },
                    { 165, 8, 56 },
                    { 166, 1, 56 },
                    { 167, 4, 57 },
                    { 168, 7, 57 },
                    { 169, 2, 57 },
                    { 170, 6, 57 },
                    { 171, 1, 57 },
                    { 172, 4, 58 },
                    { 173, 7, 58 },
                    { 174, 9, 58 },
                    { 175, 1, 59 },
                    { 176, 4, 59 },
                    { 177, 2, 59 },
                    { 178, 7, 59 },
                    { 179, 9, 59 },
                    { 180, 4, 60 },
                    { 181, 10, 60 },
                    { 182, 7, 60 }
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
        }
    }
}
