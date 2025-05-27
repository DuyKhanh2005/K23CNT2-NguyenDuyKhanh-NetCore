using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NdkLab06.Models;

namespace NdkLab06.Controllers
{
    public class NdkHomeController : Controller
    {
        private readonly ILogger<NdkHomeController> _logger;

        public NdkHomeController(ILogger<NdkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Thông tin sinh viên truyền vào ViewBag
            ViewBag.NdkName = "Nguyễn Duy Khánh";
            ViewBag.NdkMSSV = "0345865380";
            ViewBag.NdkClass = "K23CNT2";
            ViewBag.NdkEmail = "duykhanhduong088@gmail.com";
            return View();
        }

        // Nếu bạn không cần trang Privacy, có thể xóa action này và View tương ứng.
        // Giữ lại nếu muốn giữ đúng template gốc.
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}