using Microsoft.AspNetCore.Mvc;
using DEMO_MVC.Models;

namespace DEMO_MVC.Controllers
{
    public class Bai1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Bai1Model());
        }

        [HttpPost]
        public IActionResult Index(Bai1Model model)
        {
            if (model.NamSinh > 1900 && model.NamSinh <= DateTime.Now.Year)
            {
                model.Tuoi = DateTime.Now.Year - model.NamSinh;
                model.ThongBao = $"Họ tên: {model.HoTen}, Tuổi: {model.Tuoi}";
            }
            else
            {
                model.ThongBao = "Năm sinh không hợp lệ!";
            }
            return View(model);
        }
    }
}
