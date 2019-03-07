using CoreGiris.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreGiris.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var db = new MyContext();

            var data = db.Categories.Include(x => x.Products)
            // .ThenInclude(x=>x.Suppliers)
            .OrderBy(x => x.CategoryName)
            .ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var db = new MyContext();
            db.Categories.Add(new Category()
            {
                CategoryName = model.CategoryName
            });
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id = 0)
        {
            var db = new MyContext();
            var category = db.Categories.Include(x => x.Products).FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                TempData["Message"] = "Silinecek Kategori Bulunamadi.";
                return RedirectToAction(nameof(Index));
            }
            if (category.Products.Count > 0)
            {
                TempData["Message"] = $"{category.CategoryName} isimli kategoriye bagli ürün bulundugundan silemezsiniz.";
                return RedirectToAction(nameof(Index));
            }
            db.Categories.Remove(category);
            db.SaveChanges();
            TempData["Message"] = "Kategori Silindi.";
            return RedirectToAction("Index");
        }
    }
}