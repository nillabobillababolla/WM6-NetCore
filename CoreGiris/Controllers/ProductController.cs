using System.Linq;
using CoreGiris.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreGiris.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            var db = new MyContext();
            var data = db.Products.ToList();
            return View(data);
        }
    }
}