using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactShow()
        {
            return View();
        }
    }
}
