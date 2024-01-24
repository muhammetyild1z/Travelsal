using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class newtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Destinations_destinationId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_destinationId",
                table: "comments",
                newName: "IX_comments_destinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                column: "commentId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Destinations_destinationId",
                table: "comments",
                column: "destinationId",
                principalTable: "Destinations",
                principalColumn: "destinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Destinations_destinationId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.RenameTable(
                name: "comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_comments_destinationId",
                table: "Comment",
                newName: "IX_Comment_destinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "commentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Destinations_destinationId",
                table: "Comment",
                column: "destinationId",
                principalTable: "Destinations",
                principalColumn: "destinationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
