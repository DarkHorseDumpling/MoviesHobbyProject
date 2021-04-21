using Microsoft.EntityFrameworkCore;

namespace MoviesHobbyProject.Models
{
    public class MemberMoviesContext : DbContext
    {
        public MemberMoviesContext(DbContextOptions<MemberMoviesContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<GroupMembers> Members { get; set; }
        public DbSet<SavedMovies> Movies { get; set; }
        public DbSet<MovieFavorites> Favorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GroupMembers>().HasData(
                        new
                        {
                            GroupMembersID = 1,
                            FirstName = "Alainna",
                            LastName = "Nichols",
                            MemberBio = "I am a third-year student at University of Cincinnati, majoring in " +
                            "Information Technology with a concentration in Software Development. I am a full-time " +
                            "UX Development and Design Specialist for LexisNexis. I don't have a lot of time for " +
                            "hobbies, but when I do, it is usually watching TV/movies or drawing and painting.",
                            FavMovieReason = "This is an old movie I used to watch with my mother when I was young. " +
                            "I enjoy the subtle and silly humor of it. I don't watch it often, but I don't typically " +
                            "re-watch movies and always enjoy watching this one."
                        },
                        new
                        {
                            GroupMembersID = 2,
                            FirstName = "Martin",
                            LastName = "Dietel",
                            MemberBio = "I am a 33-year-old male third year student at the University " +
                            "of Cincinnati completing my Bachelors in IT with a concentration on software " +
                            "development. I love to bike, hike, watch movies and shows, listen to music, and " +
                            "a bit of gaming from time to time.",
                            FavMovieReason = "I’ve watched this movie a million times and still love it. " +
                            "The concepts are deep, the way it is shot and written is unique and fun, and " +
                            "the soundtrack is one of the best that I can think of."
                        },
                        new
                        {
                            GroupMembersID = 3,
                            FirstName = "Saleem",
                            LastName = "Dweik",
                            MemberBio = "I am a third-year student here at the University of Cincinnati, pursuing a " +
                            "degree in IT and in the software development track. I have many hobbies such as hiking, " +
                            "fishing, and woodworking.",
                            FavMovieReason = "It’s a classic. I grew up watching Finding Nemo and other Disney/Pixar " +
                            "movies and it is my favorite out of all of them. It always brings me a sense of nostalgia " +
                            "every time I watch it."
                        },
                        new
                        {
                            GroupMembersID = 4,
                            FirstName = "Danielle",
                            LastName = "Maddux",
                            MemberBio = "I am a 34-year-old female who enjoys many things from video games and tabletop " +
                            "games to athletics such as Martial Arts and skateboarding.",
                            FavMovieReason = "I love horror musicals. The movie is gory and dark. It sort of reminds me " +
                            "of the kind of dark humor that Shakespeare wrote, nobody wins at the end."
                        },
                        new
                        {
                            GroupMembersID = 5,
                            FirstName = "Vismaya",
                            LastName = "Manchaiah",
                            MemberBio = "I am a third-year student at UC majoring in Information Technology and am also " +
                            "working towards my MBA. Some of my hobbies include playing the piano, hiking, and watching movies.",
                            FavMovieReason = "I love this movie because of the unique way it portrays its characters. It " +
                            "had my interest from the moment it started and led me to think about things in a new perspective."
                        }
                 );

            modelBuilder.Entity<SavedMovies>().HasData(
                new SavedMovies
                {
                    SavedMoviesID = 1,
                    APIReferenceID = 8587,
                    MovieName = "The Lion King"
                },
                new SavedMovies
                {
                    SavedMoviesID = 2,
                    APIReferenceID = 1726,
                    MovieName = "Iron Man"
                },
                new SavedMovies
                {
                    SavedMoviesID = 3,
                    APIReferenceID = 10138,
                    MovieName = "Iron Man 2"
                },
                new SavedMovies
                {
                    SavedMoviesID = 4,
                    APIReferenceID = 68721,
                    MovieName = "Iron Man 3"
                },
                new SavedMovies
                {
                    SavedMoviesID = 5,
                    APIReferenceID = 136799,
                    MovieName = "Trolls"
                },
                new SavedMovies
                {
                    SavedMoviesID = 6,
                    APIReferenceID = 10020,
                    MovieName = "Beauty and the Beast"
                },
                new SavedMovies
                {
                    SavedMoviesID = 7,
                    APIReferenceID = 812,
                    MovieName = "Aladdin"
                },
                new SavedMovies
                {
                    SavedMoviesID = 8,
                    APIReferenceID = 2493,
                    MovieName = "The Princess Bride"
                },
                new SavedMovies
                {
                    SavedMoviesID = 9,
                    APIReferenceID = 141,
                    MovieName = "Donnie Darko"
                },
                new SavedMovies
                {
                    SavedMoviesID = 10,
                    APIReferenceID = 12,
                    MovieName = "Finding Nemo"
                },
                new SavedMovies
                {
                    SavedMoviesID = 11,
                    APIReferenceID = 14353,
                    MovieName = "Repo! The Genetic Opera"
                },
                new SavedMovies
                {
                    SavedMoviesID = 12,
                    APIReferenceID = 550,
                    MovieName = "Fight Club"
                }
            );

            modelBuilder.Entity<MovieFavorites>().HasData(
                new MovieFavorites
                {
                    MovieFavoritesID = 1,
                    Rating = 3,
                    GroupMembersID = 1,
                    SavedMoviesID = 1,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 2,
                    Rating = 4,
                    GroupMembersID = 1,
                    SavedMoviesID = 2,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 3,
                    Rating = 4,
                    GroupMembersID = 1,
                    SavedMoviesID = 3,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 4,
                    Rating = 4,
                    GroupMembersID = 1,
                    SavedMoviesID = 4,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 5,
                    Rating = 3,
                    GroupMembersID = 1,
                    SavedMoviesID = 5,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 6,
                    Rating = 4,
                    GroupMembersID = 1,
                    SavedMoviesID = 6,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 7,
                    Rating = 4,
                    GroupMembersID = 1,
                    SavedMoviesID = 7,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 8,
                    Rating = 5,
                    GroupMembersID = 1,
                    SavedMoviesID = 8,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 9,
                    Rating = 5,
                    GroupMembersID = 2,
                    SavedMoviesID = 9,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 10,
                    Rating = 5,
                    GroupMembersID = 3,
                    SavedMoviesID = 10,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 11,
                    Rating = 5,
                    GroupMembersID = 4,
                    SavedMoviesID = 11,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 12,
                    Rating = 5,
                    GroupMembersID = 5,
                    SavedMoviesID = 12,
                    IsMovie = true
                }
            );
        }
    }
}
