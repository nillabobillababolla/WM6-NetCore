using IdentityCore.Models.VM;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCore.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Kayıt olurken bir hata gerceklesti.";
                return RedirectToAction("Index", "Home");
            }



            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}