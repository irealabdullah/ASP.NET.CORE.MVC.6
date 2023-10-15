using Microsoft.AspNetCore.Mvc;

namespace _7_ConnectLayoutViewWithIndexUsingViewStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
