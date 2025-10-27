using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Carts_CartId",
                table: "ProductCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCarts_Products_ProductId",
                table: "ProductCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCarts",
                table: "ProductCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "ProductCarts",
                newName: "ProductCart");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCarts_ProductId",
                table: "ProductCart",
                newName: "IX_ProductCart_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCart",
                table: "ProductCart",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Users_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCart_Cart_CartId",
                table: "ProductCart",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCart_Products_ProductId",
                table: "ProductCart",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Users_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCart_Cart_CartId",
                table: "ProductCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCart_Products_ProductId",
                table: "ProductCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCart",
                table: "ProductCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "ProductCart",
                newName: "ProductCarts");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCart_ProductId",
                table: "ProductCarts",
                newName: "IX_ProductCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCarts",
                table: "ProductCarts",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Carts_CartId",
                table: "ProductCarts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCarts_Products_ProductId",
                table: "ProductCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
