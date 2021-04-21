using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace MoviesHobbyProject.Controllers
{
    public class GroupMembersController : Controller
    {
        private const string UriString = "https://api.themoviedb.org/3/movie/";
        private const string apiKey = "078923f64c5714a90fb9477198305522";
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
                MoviesList = movies,
                MemID = id
            };
            ViewBag.Title = "About Me";
            return View(model);
        }
        public IActionResult FavoriteMovies(int id)
        {
            var favMovies = _context.Favorites.Where(i => i.GroupMembersID == id).ToList();
            var filteredMovies = new List<SavedMovies>();
            List<string> apiValList = new List<string>();
            List<int> favIdList = new List<int>();
            List<MovieApiModel> apiItemList = new List<MovieApiModel>();
            for (int x = 0; x < favMovies.Count; x++)
            {
                favIdList.Insert(x, favMovies[x].MovieFavoritesID);
            }
            for (int x = 0; x < favMovies.Count; x++)
            {
                var tempMovies = _context.Movies.Where(i => i.SavedMoviesID == favMovies[x].SavedMoviesID);
                foreach(SavedMovies t in tempMovies)
                {
                    filteredMovies.Insert(x, t);
                }
            }
            for (int x = 0; x < filteredMovies.Count; x++)
            {
                string apiIdVal = filteredMovies[x].APIReferenceID.ToString();
                apiValList.Insert(x, apiIdVal);
            }
            for (int x = 0; x < apiValList.Count; x++)
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
                MoviesList = filteredMovies,
                ApiContentList = apiItemList
            };
            ViewBag.Title = "My Movies List";
            return View(model);
        }
    }
}
