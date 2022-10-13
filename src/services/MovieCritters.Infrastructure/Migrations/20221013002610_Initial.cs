using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCritters.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    imdb_id = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    title = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    original_title = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    is_adult = table.Column<bool>(type: "boolean", nullable: false),
                    start_year = table.Column<int>(type: "int", nullable: false),
                    end_year = table.Column<int>(type: "int", nullable: true),
                    runtime_minutes = table.Column<int>(type: "int", nullable: false),
                    genres = table.Column<string[]>(type: "text[]", nullable: true),
                    rating = table.Column<float>(type: "real", nullable: false),
                    image_url = table.Column<string>(type: "varchar", maxLength: 255, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_movies", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "created_at", "end_year", "genres", "image_url", "imdb_id", "is_adult", "original_title", "rating", "runtime_minutes", "start_year", "title", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("99a90b80-db93-4f76-a012-cbdadc878f62"), new DateTime(2022, 10, 13, 0, 26, 10, 560, DateTimeKind.Utc).AddTicks(5830), null, new[] { "Drama" }, "https://upload.wikimedia.org/wikipedia/en/2/26/One_Flew_Over_the_Cuckoo%27s_Nest_poster.jpg", "tt0073486", false, "One Flew Over the Cuckoo's Nest", 4.7f, 133, 1975, "One Flew Over the Cuckoo's Nest", "movie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99a90b80-db93-4f76-a012-cbdadc878f63"), new DateTime(2022, 10, 13, 0, 26, 10, 560, DateTimeKind.Utc).AddTicks(5849), null, new[] { "Adventure", "Animation", "Comedy" }, "https://upload.wikimedia.org/wikipedia/en/8/86/Brother_Bear_Poster.png", "tt0328880", false, "Brother Bear", 4.5f, 85, 2003, "Brother Bear", "movie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99a90b80-db93-4f76-a012-cbdadc878f64"), new DateTime(2022, 10, 13, 0, 26, 10, 560, DateTimeKind.Utc).AddTicks(5853), null, new[] { "Action", "Adventure", "Sci-Fi" }, "https://upload.wikimedia.org/wikipedia/en/0/02/Spider-Man_2_Poster.jpg", "tt0316654", false, "Spider-Man 2", 4.1f, 127, 2004, "Spider-Man 2", "movie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99a90b80-db93-4f76-a012-cbdadc878f65"), new DateTime(2022, 10, 13, 0, 26, 10, 560, DateTimeKind.Utc).AddTicks(5856), null, new[] { "Action", "Adventure", "Drama" }, "https://upload.wikimedia.org/wikipedia/en/f/fb/Gladiator_%282000_film_poster%29.png", "tt0172495", false, "Gladiator", 4.8f, 155, 2000, "Gladiator", "movie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_movies_imdb_id",
                table: "movies",
                column: "imdb_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
