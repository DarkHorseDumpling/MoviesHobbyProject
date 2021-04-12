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
        public IActionResult About(int id)
        {
            var members = context.Members.ToList();
            var model = new HobbyViewModel
            {
                TeamList = members,
                MemID = id
            };
            ViewBag.Title = "About Me";
            return View(model);
        }
        public IActionResult Favorites()
        {
            ViewBag.Title = "My Favorite Movies";
            return View();
        }
    }
}
