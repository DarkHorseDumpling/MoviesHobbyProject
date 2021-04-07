using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class MovieFavorites
    {
        [Key]
        public int MovieFavoritesID { get; set; }
        public int Rating { get; set; }
        public int GroupMembersID { get; set; }
        public int SavedMoviesID { get; set; }
        public bool IsMovie { get; set; }
        [ForeignKey("SavedMoviesID")]
        public virtual SavedMovies MovieInfo { get; set; }
        [ForeignKey("GroupMembersID")]
        public virtual GroupMembers GroupMember { get; set; }
    }
}
