using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class MovieFavorites
    {
        public int MovieFavoritesID { get; set; }
        public int Rating { get; set; }
        public int GroupMembersID { get; set; }
        public int SavedMoviesID { get; set; }
        public bool isMovie { get; set; }
    }
}
