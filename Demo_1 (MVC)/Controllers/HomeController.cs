using Microsoft.AspNetCore.Mvc;

namespace Demo_1__MVC_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewResult result = new ViewResult();
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {   
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
