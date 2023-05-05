using furnitureSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace furnitureSite.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public static PreviewModel GetPreview()
        {
            return new PreviewModel("FurnitureTitle", "Furniture Text", "Furniture");
        }


    }
}
