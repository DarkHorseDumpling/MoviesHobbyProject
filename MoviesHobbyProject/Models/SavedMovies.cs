using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class SavedMovies
    {
        [Key]
        public int SavedMoviesID { get; set; }
        public int APIReferenceID { get; set; }
        public string MovieName { get; set; }

    }
}
