
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace MovieHobbiesProject.Controllers
{
    public class HomeController : Controller
    {
public IActionResult Index()
        {
            return Redirect("~/html/index.html");
            //return View();
            //return File(Server.MapPath("/Solution/Html/") + "index.htm", "text/html");
            //return PhysicalFile("../MovieHobbiesProject/wwwroot/html/index.html" , "text/html");

        }
    }
}
