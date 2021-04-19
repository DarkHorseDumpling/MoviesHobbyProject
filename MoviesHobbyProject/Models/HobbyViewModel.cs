using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class HobbyViewModel
    {
        public ICollection<GroupMembers> TeamList { get; set; }
        public ICollection<MovieFavorites> FavoritesCollection { get; set; }
        public ICollection<SavedMovies> MoviesList { get; set; }

        public int MemID { get; set; }
        public int MovID { get; set; }
        public int FavID { get; set; }
    }
}
