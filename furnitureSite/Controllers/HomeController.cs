using furnitureSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace furnitureSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PreviewModel[] previews = 
            {
                FurnitureController.GetPreview(),
                KitchenController.GetPreview(),
                ConstructorController.GetPreview(),
            };
            return View(previews);
        }

        public IActionResult Cupboard() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}