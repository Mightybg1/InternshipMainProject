using Microsoft.AspNetCore.Mvc;

namespace PlantCare.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
