using furnitureSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace furnitureSite.Controllers
{
    public class KitchenController : Controller
    {
        // GET: KitchenController
        public ActionResult Index()
        {
            return View();
        }
        public static PreviewModel GetPreview() 
        {
            return new PreviewModel("KitchenTitle", "Kitchen Text", "Kitchen");
        }


        // GET: KitchenControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KitchenControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KitchenControler/Create
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

        // GET: KitchenControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KitchenControler/Edit/5
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

        // GET: KitchenControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KitchenControler/Delete/5
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
