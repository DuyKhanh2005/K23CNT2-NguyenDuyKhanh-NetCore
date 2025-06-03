using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NdkLesson07.Models;
using System.Diagnostics;

namespace NdkLesson07.Controllers
{
    public class NdkHomeController : Controller
    {
        private readonly ILogger<NdkHomeController> _logger;

        public NdkHomeController(ILogger<NdkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NdkIndex()
        {
            return View();
        }

        public IActionResult NdkAbout()
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