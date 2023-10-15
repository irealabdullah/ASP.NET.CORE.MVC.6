using Microsoft.AspNetCore.Mvc;

namespace _2_ConventionBasedRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public int Userdetails(int id)
        {
            return id;
        }

        public string username(string name)
        {
            return name;
        }

        public int userdetails(int a,int b)
        {
            return a + b;
        }
    }

    
    
}
