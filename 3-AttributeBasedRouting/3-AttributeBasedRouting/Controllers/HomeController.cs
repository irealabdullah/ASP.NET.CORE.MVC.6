using Microsoft.AspNetCore.Mvc;

namespace _3_AttributeBasedRouting.Controllers
{
    //WE MUST USE TWO MIDDLEWARES (SEE PROGRAM.CS)
    public class HomeController : Controller
    {
        //It will work for all of these 
       // [Route("")] //JAB HAMARA URL EMPTY HOO
        [Route("Home")] //JAB HAMARA URL MAIN CONTROLLER
       // [Route("Home/Index")] //JAB HAMARA URL MAIN CONTROLLER AUR INDEX HOO
        [Route("Index")] //JAB HAMARA INDEX KO URL MAIN CALL KARAIN   

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public IActionResult about()
        {
            return View();
        }

        //[Route("User/Login")] 
        public IActionResult Login()
        {
            return View();
        }

        [Route("Home/Details/{id}")] // we must give id
        [Route("Home/Details/{id?}")] // ? means optional
        public int Details(int id) //iska view banane ke zaroorat nahi ;)
        {
            return id;
        }

        //we can also make id nullable --> id? by using below concept

        //agar id null hai tu id main 1 ke value store karwado
        [Route("Home/userDetails/{id?}")]
        public int userDetails(int? id)
        {
            return id ?? 1;
        }

        [Route("Home/EmpID")]
        public int EmpID(int? id)
        {
            return id ?? 5;
        }

        [Route("username")]
        public string username(int? id)
        {
            return "iamabdullah_" + (id ?? 10);
        }

        //For suppose action method name is different in route still it will execute as we have given path 

        [Route("Home/Index")]
        public IActionResult display()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
