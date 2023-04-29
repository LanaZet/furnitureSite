using Microsoft.AspNetCore.Mvc;

namespace furnitureSite.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
