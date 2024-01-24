using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class destcom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reservations_destinationId",
                table: "Reservations",
                column: "destinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_destinationId",
                table: "Reservations",
                column: "destinationId",
                principalTable: "Destinations",
                principalColumn: "destinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_destinationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_destinationId",
                table: "Reservations");
        }
    }
}
