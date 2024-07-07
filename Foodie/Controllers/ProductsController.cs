using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductsShow()
        {
            return View();
        }
    }
}
