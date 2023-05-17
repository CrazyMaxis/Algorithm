using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algorithm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ALGORITHMS",
                columns: table => new
                {
                    ID_ALGORITHM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEVEL = table.Column<int>(type: "int", nullable: false),
                    IMAGE_SOURCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PATH_TO_PRESENTATION = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALGORITHMS", x => x.ID_ALGORITHM);
                });

            migrationBuilder.CreateTable(
                name: "COURSES",
                columns: table => new
                {
                    ID_COURSE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAGE_SOURCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRICE = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES", x => x.ID_COURSE);
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONS",
                columns: table => new
                {
                    ID_QUESTION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USER = table.Column<int>(type: "int", nullable: false),
                    QUESTION = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONS", x => x.ID_QUESTION);
                });

            migrationBuilder.CreateTable(
                name: "TESTS",
                columns: table => new
                {
                    ID_TEST = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEVEL = table.Column<int>(type: "int", nullable: false),
                    SOURCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAGE_SOURCE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TESTS", x => x.ID_TEST);
                });

            migrationBuilder.CreateTable(
                name: "USER_ACTIVITY",
                columns: table => new
                {
                    ID_USER_ACTIVITY = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USER = table.Column<int>(type: "int", nullable: false),
                    ID_ALGORITHM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_ACTIVITY", x => x.ID_USER_ACTIVITY);
                });

            migrationBuilder.CreateTable(
                name: "USER_COURSES",
                columns: table => new
                {
                    ID_USER_COURSE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USER = table.Column<int>(type: "int", nullable: false),
                    ID_COURSE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_COURSES", x => x.ID_USER_COURSE);
                });

            migrationBuilder.CreateTable(
                name: "USER_TESTS",
                columns: table => new
                {
                    ID_USER_TEST = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USER = table.Column<int>(type: "int", nullable: false),
                    ID_TEST = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_TESTS", x => x.ID_USER_TEST);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    ID_USER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEVEL = table.Column<int>(type: "int", nullable: false),
                    IMAGE_SOURCE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.ID_USER);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALGORITHMS");

            migrationBuilder.DropTable(
                name: "COURSES");

            migrationBuilder.DropTable(
                name: "QUESTIONS");

            migrationBuilder.DropTable(
                name: "TESTS");

            migrationBuilder.DropTable(
                name: "USER_ACTIVITY");

            migrationBuilder.DropTable(
                name: "USER_COURSES");

            migrationBuilder.DropTable(
                name: "USER_TESTS");

            migrationBuilder.DropTable(
                name: "USERS");
        }
    }
}
