using System.ComponentModel.DataAnnotations;

namespace MoviesHobbyProject.Models
{
    public class SavedMovies
    {
        [Key]
        public int SavedMoviesID { get; set; }
        [Required(ErrorMessage ="Please search within API to select a valid movie!")]
        public int? APIReferenceID { get; set; }
        [Required(ErrorMessage = "The API Validation Key is invalid!")]
        public string MovieName { get; set; }

        public string Slug
        {
            get
            {
                if (MovieName == null)
                    return "";
                else
                    return MovieName.Replace(' ', '-');
            }
        }
    }
}
