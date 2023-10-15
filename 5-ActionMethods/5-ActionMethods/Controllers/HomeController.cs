using Microsoft.AspNetCore.Mvc;

namespace _5_ActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public string username()
        {
            return "Hello Abdullah";
        }

        public string myusername(string name) //https://localhost:7296/Home/myusername?name=Ali
        {
            return name;
        }

        public int id(int? id)
        {
            return id ?? 1;
        }

        //--------------------------------------------------------
        public IActionResult Show() //This will derive all classes 
        {
            return Content("Hello");
        }
        public ContentResult Display() //This is only one class
        {
            return Content("Hello");
        }

        //---------------------------------------------
        public IActionResult Myname() 
        {
            var name = "Abdullah";
            return Json(new {data = name});
        }

        public JsonResult MyName()
        {
            var name = "Abdullah";
            return Json(new {data = name});
        }

        //----------------------------------------------

        public IActionResult PartialView()
        {
            return PartialView();
        }

        //--------------------------------
        public EmptyResult Empty()
        {
            return new EmptyResult();
        }
    }
}


//---------------------------------

// All the classes are derived from IAction result
/*
1) ViewResult: Represents a view result that renders a Razor view. It's used to return HTML views to the client.
2) JsonResult: Represents a JSON-formatted response that can be returned from a controller action.
3) FileResult: Used to return a file as the response, such as serving a downloadable file.
4) ContentResult: Represents a simple text response with content, such as plain text or HTML.
5) RedirectResult: Represents an HTTP redirect response to a different URL.
6) BadRequestResult: Represents an HTTP 400 (Bad Request) response.
7) NotFoundResult: Represents an HTTP 404 (Not Found) response.
8) UnauthorizedResult: Represents an HTTP 401 (Unauthorized) response.
9) StatusCodeResult: Represents an arbitrary HTTP status code response.

public IActionResult MyAction()
{
    // Returning a ViewResult
    return View("MyView");

    // Returning a JSON result
    return Json(new { key = "value" });

    // Returning a file
    return File("path-to-file.pdf", "application/pdf");

    // Returning a plain text response
    return Content("Hello, World!");

    // Redirecting to a different URL
    return Redirect("/otherpage");

    // Returning a 404 (Not Found) response
    return NotFound();
}
*/