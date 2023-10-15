using Microsoft.AspNetCore.Mvc;

namespace _6_RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
