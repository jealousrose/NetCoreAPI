using DEMO_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_MVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: /Person/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Person/Details
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.InfoPerson = strOutput;
            return View();
        }
    }
}
