using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class gfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "guideId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_guideId",
                table: "Destinations",
                column: "guideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_guideId",
                table: "Destinations",
                column: "guideId",
                principalTable: "Guides",
                principalColumn: "guideId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_guideId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_guideId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "guideId",
                table: "Destinations");
        }
    }
}
