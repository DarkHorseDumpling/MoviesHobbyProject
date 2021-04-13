
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using MoviesHobbyProject.Models;
using System;
using System.IO;

namespace MovieHobbiesProject.Controllers
{
    public class HomeController : Controller
    {
       // private MovieContext context { get; set; }

       // public HomeController(MovieContext ctx)
       // {
        //    context = ctx;
       // }
        public IActionResult Index()
            {
            return View("~/Views/Home/Index.cshtml");

            }
    }
}
