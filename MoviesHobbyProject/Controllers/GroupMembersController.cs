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
        private MemberMoviesContext _context;

        public GroupMembersController(MemberMoviesContext ctx)
        {
            _context = ctx;
        }
        public IActionResult About(int id)
        {
            var members = _context.Members.ToList();
            var movies = _context.Movies.OrderBy(n => n.MovieName).ToList();
            var favorites = _context.Favorites.Where(r => r.Rating == 5).ToList();
            var model = new HobbyViewModel
            {
                TeamList = members,
                FavoritesCollection = favorites,
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
