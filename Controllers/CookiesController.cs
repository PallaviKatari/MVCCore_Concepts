using Microsoft.AspNetCore.Mvc;

namespace MVCCore_Concepts.Controllers
{
    //STATE MANAGEMENT - COOKIES
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            //read cookie from Request object  
            string userName = Request.Cookies["UserName"];
            return View("Index", userName);
        }

        //View Cookie - Inspect - Application - Cookies - Running URL
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();

            //set the key value in Cookie              
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("UserName", userName, option);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveCookie()
        {
            //Delete the cookie            
            Response.Cookies.Delete("UserName");
            return View("Index");
        }
    }
}
