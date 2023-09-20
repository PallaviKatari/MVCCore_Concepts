using Microsoft.AspNetCore.Mvc;

namespace MVCCore_Concepts.Controllers
{
    //Strongly Typed Views - @model
    //Weakly Typed Views
    public class WeaklyTypedController : Controller
    {
        //ViewData
        //ViewData is a dictionary object and we can get/set values using a key.
        //ViewData exposes an instance of the ViewDataDictionary class.
        public IActionResult Index()
        {
            ViewData["UserId"] = 101;
            return View();
        }

        //ViewBag
        //ViewBag is similar to ViewData but it is a dynamic object and we can add data into it without converting to a strongly typed object.
        //In other words, ViewBag is just a dynamic wrapper around the ViewData.
        public IActionResult Index1()
        {
            ViewBag.UserId = 101;
            ViewBag.Name = "John";
            ViewBag.Age = 31;
            return View();
        }
    }
}
