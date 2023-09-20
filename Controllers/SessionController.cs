using Microsoft.AspNetCore.Mvc;
using MVCCore_Concepts.Models;

namespace MVCCore_Concepts.Controllers
{
    //STATE MANAGEMENT
    public class SessionController : Controller
    {
        //SESSION
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);
            return View();
        }
        public IActionResult Get()
        {
            User newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
            };
            return View(newUser);
        }

        //QUERYSTRING
        //https://localhost:7256/session/GetQueryString?name=John&age=31
        public IActionResult GetQueryString(string name, int age)
        {
            User newUser = new User()
            {
                Name = name,
                Age = age
            };
            return View(newUser);
        }

        //HIDDENFIELD
        //We can save data in hidden form fields and send it back in the next request.
        //Sometimes we require some data to be stored on the client side without displaying it on the page.
        //Later when the user takes some action, we’ll need that data to be passed on to the server side.
        //This is a common scenario in many applications and hidden fields provide a good solution for this.
        [HttpGet]
        public IActionResult SetHiddenFieldValue()
        {
            User newUser = new User()
            {
                Id = 101,
                Name = "John",
                Age = 31
            };
            return View(newUser);
        }

        [HttpPost]
        public IActionResult SetHiddenFieldValue(IFormCollection keyValues)
        {
            var id = keyValues["Id"];
            return View();
        }
    }
}
