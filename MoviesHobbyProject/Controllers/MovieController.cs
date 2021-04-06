using Microsoft.AspNetCore.Mvc;

namespace MovieHobbiesProject.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/html/movie.html");
        }
    }
}
