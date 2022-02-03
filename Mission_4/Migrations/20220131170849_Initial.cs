using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<uint>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edit = table.Column<string>(nullable: true),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Thriller" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Sci-fi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Musical" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 10, "Rom-Com" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "CategoryId", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Jared Hess", null, null, null, "PG", "Nacho Libre", 2006u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "CategoryId", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 2, "Jon Favreau", null, null, null, "PG-13", "Iron Man", 2008u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "CategoryId", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 5, 2, "Jon Watts", null, null, null, "PG-13", "Spider-Man: No Way Home", 2021u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "CategoryId", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 6, "Christopher Nolan", null, null, null, "PG-13", "Interstellar", 2014u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "FormId", "CategoryId", "Director", "Edit", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 4, 8, "Bill Condon", null, null, null, "PG", "Beauty and the Beast", 2017u });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
