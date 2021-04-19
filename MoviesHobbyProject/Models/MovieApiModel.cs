using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class MovieApiModel
    {
        public string Backdrop_path { get; set; }
        public BelongsToCollection Belongs_to_collection { get; set; }
        public Genre[] Genres { get; set; }
        public ICollection<SavedMovies> MoviesList { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string Imdb_id { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
    }
}
