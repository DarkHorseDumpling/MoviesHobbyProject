
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System;
using System.IO;

namespace MovieHobbiesProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
        public IActionResult AboutUs()
        {
            ViewBag.Title = "About Us";
            return View();
        }
        public IActionResult AboutOurProject()
        {
            ViewBag.Title = "About Our Project";
            return View();
        }
    }
}
