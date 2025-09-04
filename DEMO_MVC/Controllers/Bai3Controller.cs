using Microsoft.AspNetCore.Mvc;
using DEMO_MVC.Models;

namespace DEMO_MVC.Controllers
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Bai3Model());
        }

        [HttpPost]
        public IActionResult Index(Bai3Model model)
        {
            if (model.ChieuCaoCm > 0)
            {
                var h = model.ChieuCaoCm / 100.0;
                model.BMI = model.CanNang / (h * h);

                if (model.BMI < 18.5) model.DanhGia = "Gầy";
                else if (model.BMI < 25) model.DanhGia = "Bình thường";
                else if (model.BMI < 30) model.DanhGia = "Thừa cân";
                else model.DanhGia = "Béo phì";

                model.ThongBao = $"BMI: {model.BMI:F2} - {model.DanhGia}";
            }
            else
            {
                model.ThongBao = "Chiều cao phải > 0!";
                model.BMI = 0;
                model.DanhGia = string.Empty;
            }

            return View(model);
        }
    }
}
