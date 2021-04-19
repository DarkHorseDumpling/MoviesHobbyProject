using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesHobbyProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    GroupMembersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MemberBio = table.Column<string>(nullable: true),
                    FavMovieReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.GroupMembersID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    SavedMoviesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIReferenceID = table.Column<int>(nullable: false),
                    MovieName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.SavedMoviesID);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    MovieFavoritesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    GroupMembersID = table.Column<int>(nullable: false),
                    SavedMoviesID = table.Column<int>(nullable: false),
                    IsMovie = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.MovieFavoritesID);
                    table.ForeignKey(
                        name: "FK_Favorites_Members_GroupMembersID",
                        column: x => x.GroupMembersID,
                        principalTable: "Members",
                        principalColumn: "GroupMembersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Movies_SavedMoviesID",
                        column: x => x.SavedMoviesID,
                        principalTable: "Movies",
                        principalColumn: "SavedMoviesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "GroupMembersID", "FavMovieReason", "FirstName", "LastName", "MemberBio" },
                values: new object[,]
                {
                    { 1, "This is an old movie I used to watch with my mother when I was young. I enjoy the subtle and silly humor of it. I don't watch it often, but I don't typically re-watch movies and always enjoy watching this one.", "Alainna", "Nichols", "I am a third-year student at University of Cincinnati, majoring in Information Technology with a concentration in Software Development. I am a full-time UX Development and Design Specialist for LexisNexis. I don't have a lot of time for hobbies, but when I do, it is usually watching TV/movies or drawing and painting." },
                    { 2, "I’ve watched this movie a million times and still love it. The concepts are deep, the way it is shot and written is unique and fun, and the soundtrack is one of the best that I can think of.", "Martin", "Dietel", "I am a 33-year-old male third year student at the University of Cincinnati completing my Bachelors in IT with a concentration on software development. I love to bike, hike, watch movies and shows, listen to music, and a bit of gaming from time to time." },
                    { 3, "It’s a classic. I grew up watching Finding Nemo and other Disney/Pixar movies and it is my favorite out of all of them. It always brings me a sense of nostalgia every time I watch it.", "Saleem", "Dweik", "I am a third-year student here at the University of Cincinnati, pursuing a degree in IT and in the software development track. I have many hobbies such as hiking, fishing, and woodworking." },
                    { 4, "I love horror musicals. The movie is gory and dark. It sort of reminds me of the kind of dark humor that Shakespeare wrote, nobody wins at the end.", "Danielle", "Maddux", "I am a 34-year-old female who enjoys many things from video games and tabletop games to athletics such as Martial Arts and skateboarding." },
                    { 5, "I love this movie because of the unique way it portrays its characters. It had my interest from the moment it started and led me to think about things in a new perspective.", "Vismaya", "Manchaiah", "I am a third-year student at UC majoring in Information Technology and am also working towards my MBA. Some of my hobbies include playing the piano, hiking, and watching movies." }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "SavedMoviesID", "APIReferenceID", "MovieName" },
                values: new object[,]
                {
                    { 10, 12, "Finding Nemo" },
                    { 9, 141, "Donnie Darko" },
                    { 8, 2493, "The Princess Bride" },
                    { 7, 812, "Aladdin" },
                    { 6, 10020, "Beauty and the Beast" },
                    { 4, 68721, "Iron Man 3" },
                    { 11, 14353, "Repo! The Genetic Opera" },
                    { 3, 10138, "Iron Man 2" },
                    { 2, 1726, "Iron Man" },
                    { 1, 8587, "The Lion King" },
                    { 5, 136799, "Trolls" },
                    { 12, 550, "Fight Club" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "MovieFavoritesID", "GroupMembersID", "IsMovie", "Rating", "SavedMoviesID" },
                values: new object[,]
                {
                    { 1, 1, true, 3, 1 },
                    { 2, 1, true, 4, 2 },
                    { 3, 1, true, 4, 3 },
                    { 4, 1, true, 4, 4 },
                    { 5, 1, true, 3, 5 },
                    { 6, 1, true, 4, 6 },
                    { 7, 1, true, 4, 7 },
                    { 8, 1, true, 5, 8 },
                    { 9, 2, true, 5, 9 },
                    { 10, 3, true, 5, 10 },
                    { 11, 4, true, 5, 11 },
                    { 12, 5, true, 5, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_GroupMembersID",
                table: "Favorites",
                column: "GroupMembersID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_SavedMoviesID",
                table: "Favorites",
                column: "SavedMoviesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
