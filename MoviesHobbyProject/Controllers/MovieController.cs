using Microsoft.AspNetCore.Mvc;

namespace MovieHobbiesProject.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Movie/MovieInfo.cshtml");
        }
    }
}
