using Microsoft.AspNetCore.Mvc;

namespace DEMO_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Employee/Profile
        public IActionResult Profile()
        {
            return View();
        }
    }
}
