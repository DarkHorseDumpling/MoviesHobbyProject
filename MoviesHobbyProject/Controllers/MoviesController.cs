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
            List<string> apiValList = new List<string>();
            List<MovieApiModel> apiItemList = new List<MovieApiModel>();
            for (int x = 0; x < allMovies.Count; x++)
            {
                string apiIdVal = allMovies[x].APIReferenceID.ToString();
                apiValList.Insert(x, apiIdVal);
            }
            for (int x=0; x < apiValList.Count; x++)
            {
                MovieApiModel movie = new MovieApiModel();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(UriString);
                    var responseTask = client.GetAsync(apiValList[x] + "?api_key=" + apiKey);
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
                    apiItemList.Insert(x, movie);
                }

            }
            var model = new HobbyViewModel
            {
                MoviesList = allMovies,
                ApiContentList = apiItemList
            };
            ViewBag.Title = "All Movies";
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "Add A New Movie";
            ViewBag.AddID = "0";
            this.LoadViewBag();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit the Movie";
            ViewBag.AddID = id;
            this.LoadViewBag();
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
            MovieFavorites favorite = new MovieFavorites
            {
                Rating = selectedMovie.FavRating,
                GroupMembersID = selectedMovie.MemID,
                SavedMoviesID = selectedMovie.MovID,
                IsMovie = true,
                MovieInfo = selectedMovie.Movie
            };
            if (ModelState.IsValid)
            {
                if(selectedMovie.MovID == 0)
                {
                    _context.Movies.Add(selectedMovie.Movie);
                    _context.Favorites.Add(favorite);
                }
                else
                {
                    _context.Movies.Update(selectedMovie.Movie);
                    _context.Favorites.Update(favorite);
                }
                _context.SaveChanges();
                return RedirectToAction("ViewAll");
            }
            else
            {
                ViewBag.Title = "Add A New Movie";
                ViewBag.AddID = "0";
                this.LoadViewBag();
                return View("Add");
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

        private void LoadViewBag()
        {
            ViewBag.GroupMembers = _context.Members.ToList();
        }
    }
}
