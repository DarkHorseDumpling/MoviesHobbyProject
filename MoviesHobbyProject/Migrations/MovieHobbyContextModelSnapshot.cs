using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using MoviesHobbyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Migrations
{
    [DbContext(typeof(MovieHobbyContext))]
    public class MovieHobbyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesHobbyProject.Models.GroupMembers", b =>
            {
                b.Property<int>("GroupMembersID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("FirstName")
                    .IsRequired();

                b.Property<string>("LastName")
                    .IsRequired();

                b.Property<string>("MemberBio")
                    .IsRequired();

                b.HasKey("GroupMembersID");

                b.ToTable("GroupMembers");

                b.HasData(
                    new
                    {
                        GroupMembersID = 1,
                        FirstName = "Alainna",
                        LastName = "Nichols",
                        MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae. Faucibus ornare suspendisse sed nisi. In mollis nunc sed id semper risus in. Non consectetur a erat nam at lectus. Amet venenatis urna cursus eget nunc scelerisque. Nulla facilisi morbi tempus iaculis urna. <br />Aliquam faucibus purus in massa. Turpis nunc eget lorem dolor. Mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Nunc lobortis mattis aliquam faucibus purus in. Sapien faucibus et molestie ac. Id neque aliquam vestibulum morbi. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum integer. Elit eget gravida cum sociis. Et netus et malesuada fames ac turpis egestas integer eget. Eleifend donec pretium vulputate sapien nec sagittis. Viverra aliquet eget sit amet tellus cras adipiscing enim. Morbi enim nunc faucibus a pellentesque sit amet porttitor. Leo urna molestie at elementum eu facilisis."
                    },
                    new
                    {
                        GroupMembersID = 2,
                        FirstName = "Martin",
                        LastName = "Dietal",
                        MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae. Faucibus ornare suspendisse sed nisi. In mollis nunc sed id semper risus in. Non consectetur a erat nam at lectus. Amet venenatis urna cursus eget nunc scelerisque. Nulla facilisi morbi tempus iaculis urna. <br />Aliquam faucibus purus in massa. Turpis nunc eget lorem dolor. Mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Nunc lobortis mattis aliquam faucibus purus in. Sapien faucibus et molestie ac. Id neque aliquam vestibulum morbi. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum integer. Elit eget gravida cum sociis. Et netus et malesuada fames ac turpis egestas integer eget. Eleifend donec pretium vulputate sapien nec sagittis. Viverra aliquet eget sit amet tellus cras adipiscing enim. Morbi enim nunc faucibus a pellentesque sit amet porttitor. Leo urna molestie at elementum eu facilisis."
                    },
                    new
                    {
                        GroupMembersID = 3,
                        FirstName = "Saleem",
                        LastName = "Dweik",
                        MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae. Faucibus ornare suspendisse sed nisi. In mollis nunc sed id semper risus in. Non consectetur a erat nam at lectus. Amet venenatis urna cursus eget nunc scelerisque. Nulla facilisi morbi tempus iaculis urna. <br />Aliquam faucibus purus in massa. Turpis nunc eget lorem dolor. Mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Nunc lobortis mattis aliquam faucibus purus in. Sapien faucibus et molestie ac. Id neque aliquam vestibulum morbi. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum integer. Elit eget gravida cum sociis. Et netus et malesuada fames ac turpis egestas integer eget. Eleifend donec pretium vulputate sapien nec sagittis. Viverra aliquet eget sit amet tellus cras adipiscing enim. Morbi enim nunc faucibus a pellentesque sit amet porttitor. Leo urna molestie at elementum eu facilisis."
                    },
                    new
                    {
                        GroupMembersID = 4,
                        FirstName = "Danielle",
                        LastName = "Maddux",
                        MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae. Faucibus ornare suspendisse sed nisi. In mollis nunc sed id semper risus in. Non consectetur a erat nam at lectus. Amet venenatis urna cursus eget nunc scelerisque. Nulla facilisi morbi tempus iaculis urna. <br />Aliquam faucibus purus in massa. Turpis nunc eget lorem dolor. Mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Nunc lobortis mattis aliquam faucibus purus in. Sapien faucibus et molestie ac. Id neque aliquam vestibulum morbi. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum integer. Elit eget gravida cum sociis. Et netus et malesuada fames ac turpis egestas integer eget. Eleifend donec pretium vulputate sapien nec sagittis. Viverra aliquet eget sit amet tellus cras adipiscing enim. Morbi enim nunc faucibus a pellentesque sit amet porttitor. Leo urna molestie at elementum eu facilisis."
                    },
                    new
                    {
                        GroupMembersID = 5,
                        FirstName = "Vismaya",
                        LastName = "Manchaiah",
                        MemberBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis a cras semper auctor neque vitae. Faucibus ornare suspendisse sed nisi. In mollis nunc sed id semper risus in. Non consectetur a erat nam at lectus. Amet venenatis urna cursus eget nunc scelerisque. Nulla facilisi morbi tempus iaculis urna. <br />Aliquam faucibus purus in massa. Turpis nunc eget lorem dolor. Mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Nunc lobortis mattis aliquam faucibus purus in. Sapien faucibus et molestie ac. Id neque aliquam vestibulum morbi. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum integer. Elit eget gravida cum sociis. Et netus et malesuada fames ac turpis egestas integer eget. Eleifend donec pretium vulputate sapien nec sagittis. Viverra aliquet eget sit amet tellus cras adipiscing enim. Morbi enim nunc faucibus a pellentesque sit amet porttitor. Leo urna molestie at elementum eu facilisis."
                    });
            });

            modelBuilder.Entity("MoviesHobbyProject.Models.SavedMovies", b =>
            {
                b.Property<int>("SavedMoviesID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("APIReferenceID")
                    .IsRequired();

                b.Property<string>("MovieName")
                    .IsRequired();

                b.HasIndex("SavedMoviesID");

                b.HasKey("SavedMoviesID");

                b.ToTable("SavedMovies");

                b.HasData(
                    new
                    {
                        SavedMoviesID = 1,
                        APIReferenceID = 8587,
                        Name = "The Lion King"
                    },
                    new
                    {
                        SavedMoviesID = 2,
                        APIReferenceID = 1726,
                        Name = "Iron Man"
                    },
                    new
                    {
                        SavedMoviesID = 3,
                        APIReferenceID = 10138,
                        Name = "Iron Man 2"
                    },
                    new
                    {
                        SavedMoviesID = 4,
                        APIReferenceID = 68721,
                        Name = "Iron Man 3"
                    },
                    new
                    {
                        SavedMoviesID = 5,
                        APIReferenceID = 136799,
                        Name = "Trolls"
                    },
                    new
                    {
                        SavedMoviesID = 6,
                        APIReferenceID = 10020,
                        Name = "Beauty and the Beast"
                    },
                    new
                    {
                        SavedMoviesID = 7,
                        APIReferenceID = 812,
                        Name = "Aladdin"
                    },
                    new
                    {
                        SavedMoviesID = 8,
                        APIReferenceID = 2493,
                        Name = "The Princess Bride"
                    });
            });

            modelBuilder.Entity("MoviesHobbyProject.Models.MovieFavorites", b =>
            {
                b.Property<int>("MovieFavoritesID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
                
                b.Property<int>("Rating")
                    .IsRequired();

                b.Property<int>("GroupMembersID")
                    .IsRequired();

                b.Property<int>("SavedMoviesID")
                    .IsRequired();

                b.Property<bool>("isMovie");

                b.HasKey("SavedMoviesID");

                b.HasData(
                    new
                    {
                        MovieFavoritesID = 1,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 1,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 2,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 2,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 3,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 3,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 4,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 4,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 5,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 5,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 6,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 6,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 7,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 7,
                        isMovie = true
                    },
                    new
                    {
                        MovieFavoritesID = 8,
                        Rating = 1,
                        GroupMembersID = 1,
                        SavedMoviesID = 8,
                        isMovie = true
                    });
            });
        }
    }
}
