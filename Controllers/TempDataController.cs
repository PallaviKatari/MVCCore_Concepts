using Microsoft.AspNetCore.Mvc;

namespace MVCCore_Concepts.Controllers
{
    public class TempDataController : Controller
    {
        //STATE MANAGEMENT
        //TEMPDATA
        //ASP.NET Core exposes the TempData property which can be used to store data until it is read.
        //We can use the Keep() and Peek() methods to examine the data without deletion.
        //TempData is particularly useful when we require the data for more than a single request.
        //We can access them from controllers and views.
        public IActionResult First()
        {
            TempData["UserId"] = 101;
            return View();
        }
        public IActionResult Second()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }
        public IActionResult Third()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }   
    }
}
