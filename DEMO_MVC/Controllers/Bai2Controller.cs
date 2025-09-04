using Microsoft.AspNetCore.Mvc;
using DEMO_MVC.Models;

namespace DEMO_MVC.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Bai2Model());
        }

        [HttpPost]
        public IActionResult Index(Bai2Model model)
        {
            switch (model.PhepTinh)
            {
                case "Cong":
                    model.KetQua = model.So1 + model.So2;
                    break;
                case "Tru":
                    model.KetQua = model.So1 - model.So2;
                    break;
                case "Nhan":
                    model.KetQua = model.So1 * model.So2;
                    break;
                case "Chia":
                    model.KetQua = model.So2 != 0 ? model.So1 / model.So2 : double.NaN;
                    break;
            }

            if (double.IsNaN(model.KetQua))
                model.ThongBao = "Không thể chia cho 0!";
            else
                model.ThongBao = $"Kết quả: {model.KetQua}";

            return View(model);
        }
    }
}
