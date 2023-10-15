using Microsoft.AspNetCore.Mvc;

namespace _3_AttributeBasedRouting.Controllers
{
    //we can also apply [ROUTE] on controller

    [Route("User")] // to remove repitition/duplication we can use this for once
    
    public class UserController : Controller
    {
        [Route("")] //Here it will give error as we have mentioned above [Route("User")] //[Route("User")] yeh chale ga //pehle solution: [Route("~/")]
        [Route("Login")]
        [Route("~/")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
