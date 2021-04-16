using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System.Linq;

namespace MovieHobbiesProject.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MemberMoviesContext _context;

        public MoviesController(MemberMoviesContext ctx)
        {
            _context = ctx;
        }
        public IActionResult ViewAll()
        {
            var allMovies = _context.Movies
                .OrderBy(m => m.MovieName).ToList();
            var model = new HobbyViewModel
            {
                MoviesList = allMovies
            };
            ViewBag.Title = "All Movies";
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "Add A New Movie";
            ViewBag.AddID = "0";
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit the Movie";
            ViewBag.AddID = id;
            MovieViewModel movie = new MovieViewModel
            {
                Movie = _context.Movies
                .FirstOrDefault(m => m.SavedMoviesID == id)
            };
            return View("Add", movie);
        }
        [HttpPost]
        public IActionResult Edit(MovieViewModel selectedMovie)
        {
            if (ModelState.IsValid)
            {
                if(selectedMovie.MovID == 0)
                {
                    _context.Movies.Add(selectedMovie.Movie);
                }
                else
                {
                    _context.Movies.Update(selectedMovie.Movie);
                }
                _context.SaveChanges();
                return RedirectToAction("ViewAll");
            }
            else
            {
                return View("MovieDetails", selectedMovie.Movie);
            }
        }
        public IActionResult MovieDetails(int id)
        {
            var selectedMovie = _context.Movies.FirstOrDefault(x => x.SavedMoviesID == id);
            var model = new MovieViewModel
            {
                Movie = selectedMovie,
                MovID = id
            };
            return View(model);
        }
    }
}
