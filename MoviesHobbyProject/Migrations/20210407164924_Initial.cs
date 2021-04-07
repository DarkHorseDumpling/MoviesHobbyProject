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
                    MemberBio = table.Column<string>(nullable: true)
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
                columns: new[] { "GroupMembersID", "FirstName", "LastName", "MemberBio" },
                values: new object[,]
                {
                    { 1, "Alainna", "Nichols", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae." },
                    { 2, "Martin", "Dietal", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae." },
                    { 3, "Saleem", "Dweik", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae." },
                    { 4, "Danielle", "Maddux", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae." },
                    { 5, "Vismaya", "Manchaiah", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae." }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "SavedMoviesID", "APIReferenceID", "MovieName" },
                values: new object[,]
                {
                    { 1, 8587, "The Lion King" },
                    { 2, 1726, "Iron Man" },
                    { 3, 10138, "Iron Man 2" },
                    { 4, 68721, "Iron Man 3" },
                    { 5, 136799, "Trolls" },
                    { 6, 10020, "Beauty and the Beast" },
                    { 7, 812, "Aladdin" },
                    { 8, 2493, "The Princess Bride" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "MovieFavoritesID", "GroupMembersID", "IsMovie", "Rating", "SavedMoviesID" },
                values: new object[,]
                {
                    { 1, 1, true, 1, 1 },
                    { 2, 1, true, 1, 2 },
                    { 3, 1, true, 1, 3 },
                    { 4, 1, true, 1, 4 },
                    { 5, 1, true, 1, 5 },
                    { 6, 1, true, 1, 6 },
                    { 7, 1, true, 1, 7 },
                    { 8, 1, true, 1, 8 }
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
