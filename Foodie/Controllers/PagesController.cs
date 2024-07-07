using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult BlogGrid()
        {
            return View();
        }
        public IActionResult OurFeature()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult ErrorPages()
        {
            return View();
        }

    }
}
