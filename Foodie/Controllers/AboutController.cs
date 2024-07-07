using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutShow()
        {
            return View();
        }
    }
}
