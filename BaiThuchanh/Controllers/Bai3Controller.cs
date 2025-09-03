using Microsoft.AspNetCore.Mvc;
using BaiThuchanh.Models;
namespace BaiThuchanh.Controllers
{
    public class Bai3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMI model)
        {
            model.Tinh();
            return View("Ketqua", model);
        }
    }
}
