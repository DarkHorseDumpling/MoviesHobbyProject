using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MoviesHobbyProject.Models
{
    public class MovieHobbyContext : DbContext
    {
        public MovieHobbyContext(DbContextOptions<MovieHobbyContext> options) : base(options)
        { }

    }
}
