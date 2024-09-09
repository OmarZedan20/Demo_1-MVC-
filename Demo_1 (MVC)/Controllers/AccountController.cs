using Microsoft.AspNetCore.Mvc;

namespace Demo_1__MVC_.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            ViewResult result = new ViewResult();
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
