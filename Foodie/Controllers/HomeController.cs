using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
