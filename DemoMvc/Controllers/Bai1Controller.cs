using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace Bai1Controller.Controllers
{
    public class Bai1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Bai1Controller bai1)
        {
            return View(bai1);
        }
        /* xử lý dữ liệu sau khi ấn submit và trả về kết quả view */
    }
}
