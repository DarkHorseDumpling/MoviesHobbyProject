using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace MovieHobbiesProject.Controllers
{
    public class MoviesController : Controller
    {
        private const string UriString = "https://api.themoviedb.org/3/movie/";
        private const string apiKey = "078923f64c5714a90fb9477198305522";
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
        public ActionResult MovieDetails(int id)
        {
            ViewBag.Title = "Movie Details";
            var selectedMovie = _context.Movies.FirstOrDefault(x => x.SavedMoviesID == id);
            string apiIdVal = selectedMovie.APIReferenceID.ToString();
            MovieApiModel movie = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(UriString);
                var responseTask = client.GetAsync(apiIdVal + "?api_key=" + apiKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MovieApiModel>();
                    readTask.Wait();

                    movie = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact admin.");
                }
                return View(movie);
            }
        }
    }
}
