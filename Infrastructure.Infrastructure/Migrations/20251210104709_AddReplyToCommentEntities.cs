using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddReplyToCommentEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReelCommentReplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReelCommentReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReelCommentReplies_ReelComment_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "ReelComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReelCommentReplies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReelCommentReplyLoves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReelCommentReplyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReelCommentReplyLoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReelCommentReplyLoves_ReelCommentReplies_ReelCommentReplyId",
                        column: x => x.ReelCommentReplyId,
                        principalTable: "ReelCommentReplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReelCommentReplyLoves_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentReplies_ParentCommentId",
                table: "ReelCommentReplies",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentReplies_UserId",
                table: "ReelCommentReplies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentReplyLoves_ReelCommentReplyId_UserId",
                table: "ReelCommentReplyLoves",
                columns: new[] { "ReelCommentReplyId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReelCommentReplyLoves_UserId",
                table: "ReelCommentReplyLoves",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReelCommentReplyLoves");

            migrationBuilder.DropTable(
                name: "ReelCommentReplies");
        }
    }
}
