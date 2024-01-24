using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_comment_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    commentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commetUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commetContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commetStatus = table.Column<bool>(type: "bit", nullable: false),
                    destinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_Comment_Destinations_destinationId",
                        column: x => x.destinationId,
                        principalTable: "Destinations",
                        principalColumn: "destinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_destinationId",
                table: "Comment",
                column: "destinationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}
