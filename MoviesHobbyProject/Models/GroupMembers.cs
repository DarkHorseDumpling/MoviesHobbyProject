using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Models
{
    public class GroupMembers
    {
        [Key]
        public int GroupMembersID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberBio { get; set; }
        public string FavMovieReason { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
