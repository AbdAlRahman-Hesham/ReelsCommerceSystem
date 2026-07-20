using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReelsCommenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReelComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReelComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReelComment_Reels_ReelId",
                        column: x => x.ReelId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReelComment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReelCommentLove",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReelCommentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReelCommentLove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReelCommentLove_ReelComment_ReelCommentId",
                        column: x => x.ReelCommentId,
                        principalTable: "ReelComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReelCommentLove_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReelComment_ReelId",
                table: "ReelComment",
                column: "ReelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReelComment_UserId",
                table: "ReelComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentLove_ReelCommentId_UserId",
                table: "ReelCommentLove",
                columns: new[] { "ReelCommentId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentLove_UserId",
                table: "ReelCommentLove",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReelCommentLove");

            migrationBuilder.DropTable(
                name: "ReelComment");
        }
    }
}
