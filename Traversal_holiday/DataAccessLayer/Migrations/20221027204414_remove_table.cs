using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class remove_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Features2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    featureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    featurePostDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostStatus1 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.featureId);
                });

            migrationBuilder.CreateTable(
                name: "Features2",
                columns: table => new
                {
                    featureId2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    featurePostDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostStatus2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features2", x => x.featureId2);
                });
        }
    }
}
