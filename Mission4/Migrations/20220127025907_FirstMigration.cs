using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lentto = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lentto", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Horror", "Speilberg", false, "", "Scariest movie ever!", "R", "The Shining", "1980" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lentto", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "taiki watiti", false, "", "Best movie ever!", "PG-13", "End game", "2019" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lentto", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Feel good", "Matt Damon", false, "", "Best movie ever!", "R", "Good Will Hunting", "1975" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
