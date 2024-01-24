using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration_destination_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "featurePostBigImage1",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "destinationDetails1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "destinationDetails2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "destinationImage2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "destinationcreateDate",
                table: "Destinations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "featurePostBigImage1",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "destinationDetails1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "destinationDetails2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "destinationImage2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "destinationcreateDate",
                table: "Destinations");
        }
    }
}
