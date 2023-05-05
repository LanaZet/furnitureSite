using furnitureSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace furnitureSite.Controllers
{
    public class ConstructorController : Controller
    {
        // GET: ConstructorController1
        public ActionResult Index()
        {
            return View();
        }

        public static PreviewModel GetPreview()
        {
            return new PreviewModel("ConstructorTitle", "Constructor Text", "Constructor");
        }

        // GET: ConstructorController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConstructorController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConstructorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstructorController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConstructorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstructorController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConstructorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
