using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System.Linq;

namespace MovieHobbiesProject.Controllers
{
    public class MoviesController : Controller
    {
        private MemberMoviesContext context;

        public MoviesController(MemberMoviesContext ctx)
        {
            context = ctx;
        }
        public IActionResult ViewAll()
        {
            var allMovies = context.Movies
                .OrderBy(m => m.MovieName).ToList();
            var model = new HobbyViewModel
            {
                MoviesList = allMovies
            };
            ViewBag.Title = "All Movies";
            return View(model);
        }
        public IActionResult Add()
        {
            ViewBag.Title = "Add A New Movie";
            return View();
        }
    }
}
