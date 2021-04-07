using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                new GroupMembers
                {
                    GroupMembersID = 1,
                    FirstName = "Alainna",
                    LastName = "Nichols",
                    MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Convallis a cras semper auctor neque vitae."
                },
                new GroupMembers
                {
                    GroupMembersID = 2,
                    FirstName = "Martin",
                    LastName = "Dietal",
                    MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Convallis a cras semper auctor neque vitae."
                },
                new GroupMembers
                {
                    GroupMembersID = 3,
                    FirstName = "Saleem",
                    LastName = "Dweik",
                    MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Convallis a cras semper auctor neque vitae."
                },
                new GroupMembers
                {
                    GroupMembersID = 4,
                    FirstName = "Danielle",
                    LastName = "Maddux",
                    MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Convallis a cras semper auctor neque vitae."
                },
                new GroupMembers
                {
                    GroupMembersID = 5,
                    FirstName = "Vismaya",
                    LastName = "Manchaiah",
                    MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Convallis a cras semper auctor neque vitae."
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
                }
            );

            modelBuilder.Entity<MovieFavorites>().HasData(
                new MovieFavorites
                {
                    MovieFavoritesID = 1,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 1,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 2,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 2,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 3,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 3,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 4,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 4,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 5,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 5,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 6,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 6,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 7,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 7,
                    IsMovie = true
                },
                new MovieFavorites
                {
                    MovieFavoritesID = 8,
                    Rating = 1,
                    GroupMembersID = 1,
                    SavedMoviesID = 8,
                    IsMovie = true
                }
            );
        }
    }
}
