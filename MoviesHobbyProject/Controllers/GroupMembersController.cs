using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesHobbyProject.Controllers
{
    public class GroupMembersController : Controller
    {
        private MemberMoviesContext context;

        public GroupMembersController(MemberMoviesContext ctx)
        {
            context = ctx;
        }
        public IActionResult About(int id) //untested method
        {
            var members = context.Members
                .Where(m => m.GroupMembersID == id);
            var model = new HobbyViewModel
            {
                MemID = id
            };
            ViewBag.Title = "About Me";
            return View();
        }
        public IActionResult Favorites()
        {
            ViewBag.Title = "My Favorite Movies";
            return View();
        }
    }
}
