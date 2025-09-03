using Microsoft.AspNetCore.Mvc;
using BaiThuchanh.Models;
namespace BaiThuchanh.Controllers
{
    public class Bai1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Bai1 bai1)
        {
            return View(bai1);
        }
        /* xử lý dữ liệu sau khi ấn submit và trả về kết quả view */
    }
}