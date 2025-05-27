using Microsoft.AspNetCore.Mvc;
using NdkLesson05.Models.DataModels;

namespace NdkLesson05.Controllers
{
    public class NdkMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NdkGetMember()
        {
            var member = new NdkMember();
            member.NdkMemberID = Guid.NewGuid().ToString();
            member.NdkUserName = "Duy Khánh";
            member.NdkFullName = "Nguyễn Duy Khánh";
            member.NdkPassword = "@12345678";
            member.NdkEmail = "duykhanhduong088@gmail.com";

            ViewBag.NdkMember = member;
            return View();
        }
    }
}