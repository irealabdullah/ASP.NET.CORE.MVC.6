using Microsoft.AspNetCore.Mvc;

namespace _3_AttributeBasedRouting.Controllers
{
    //we can also pass [TOKENS]

    [Route("[controller]/[action]")]
    public class AuthController : Controller
    {
        // [Route("[action]")] //ab yahan deene ke zaroorat nahi kyun ke upper jo define kardia hai 

        [Route("")]
        [Route("~/")]
        [Route("~/Home")] //This is also a concept 
        public IActionResult METHOD()
        {
            return View();
        }

      //  [Route("[action]")] //ab yahan deene ke zaroorat nahi kyun ke upper jo define kardia hai 
        public IActionResult METHOD_WORK()
        {
            return View();
        }
    }
}
