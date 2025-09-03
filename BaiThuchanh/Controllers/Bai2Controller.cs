using Microsoft.AspNetCore.Mvc;
using BaiThuchanh.Models;
namespace BaiThuchanh.Controllers
{
    public class Bai2Controller : Controller
    {
        /* form nhập */
        public IActionResult Index()
        {
            return View();
        }
        // xử lý khi submit form
        [HttpPost]
        public IActionResult Index(Pheptinh model)
        {
            model.Tinh();
            return View("Ketqua", model);
        }
    }
}