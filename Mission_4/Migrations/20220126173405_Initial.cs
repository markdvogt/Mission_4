using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<uint>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edit = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.FormId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Comedy", "Jared Hess", false, null, null, "PG", "Nacho Libre", 2006u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sci-fi/Adventure", "Christopher Nolan", false, null, null, "PG-13", "Interstellar", 2014u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Jon Favreau", false, null, null, "PG-13", "Iron Man", 2008u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 4, "Musical/Romance", "Bill Condon", false, null, null, "PG", "Beauty and the Beast", 2017u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "Category", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 5, "Action/Adventure", "Jon Watts", false, null, null, "PG-13", "Spider-Man: No Way Home", 2021u });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
