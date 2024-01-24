using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class context_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    aboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.aboutId);
                });

            migrationBuilder.CreateTable(
                name: "Abouts2",
                columns: table => new
                {
                    aboutId2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts2", x => x.aboutId2);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactId);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    destinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationDayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationPrice = table.Column<double>(type: "float", nullable: false),
                    destinationImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationStatus = table.Column<bool>(type: "bit", nullable: false),
                    destinationCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.destinationId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    featureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    featurePostName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    featurePostName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    featurePostStatus2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features2", x => x.featureId2);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    guideId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guideDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guideTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guideInstgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guideStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.guideId);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    newsletterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    newsletterMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.newsletterId);
                });

            migrationBuilder.CreateTable(
                name: "SubAbouts",
                columns: table => new
                {
                    subAboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAbouts", x => x.subAboutId);
                });

            migrationBuilder.CreateTable(
                name: "TestiMonials",
                columns: table => new
                {
                    testiMonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    testiMonialClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testiMonialComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testiMonialClientImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testiMonialStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestiMonials", x => x.testiMonialId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Abouts2");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Features2");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "SubAbouts");

            migrationBuilder.DropTable(
                name: "TestiMonials");
        }
    }
}
