using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdkLesson08.Models;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace NdkLesson08.Controllers
{
    public class NdkAccountController : Controller
    {
        private static List<NdkAccount> NdkListAccount = new List<NdkAccount>()
        {
            new NdkAccount
            {
                NdkId = 230022113,
                NdkFullName = "Nguyễn Duy Khánh",
                NdkEmail = "duykhanhduong088@gmail.com",
                NdkPhone = "0345865380",
                NdkAddress = "Lớp K23CNT2",
                NdkAvatar = "chungtrinhj.jpg",
                NdkBirthday = new DateTime(2005, 1, 13),
                NdkGender = "Nam",
                NdkPassword = "0345865380",
                NdkFacebook = "https://www.facebook.com/khanhnguyen1301"
            },

        };

        // GET: Danh sách
        public ActionResult NdkIndex() => View(NdkListAccount);

        // GET: Chi tiết
        public ActionResult Details(int id)
        {
            var account = NdkListAccount.FirstOrDefault(x => x.NdkId == id);
            if (account == null) return NotFound("Không tìm thấy tài khoản!");
            return View(account);
        }
        // GET: NdkAccountController/Create
        public ActionResult NdkCreate()
        {
            var NdkModel = new NdkAccount();
            return View(NdkModel);
        }

        // POST: NdkAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdkCreate(NdkAccount NdkModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Giả sử bạn có DbContext tên _context đã được Inject trong Controller
                    //_context.NdkAccounts.Add(NdkModel);
                    //_context.SaveChanges();
                    NdkListAccount.Add(NdkModel);
                    return RedirectToAction(nameof(NdkIndex));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(NdkModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(NdkModel);
            }
        }

        // POST: NdkAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdkEdit(int id, NdkAccount updatedAccount)
        {
            try
            {
                var existingAccount = NdkListAccount.FirstOrDefault(a => a.NdkId == id);
                if (existingAccount == null)
                {
                    return NotFound();
                }

                // Cập nhật thông tin
                existingAccount.NdkFullName = updatedAccount.NdkFullName;
                existingAccount.NdkEmail = updatedAccount.NdkEmail;
                existingAccount.NdkPhone = updatedAccount.NdkPhone;
                existingAccount.NdkAddress = updatedAccount.NdkAddress;
                existingAccount.NdkAvatar = updatedAccount.NdkAvatar;
                existingAccount.NdkBirthday = updatedAccount.NdkBirthday;
                existingAccount.NdkGender = updatedAccount.NdkGender;
                existingAccount.NdkPassword = updatedAccount.NdkPassword;
                existingAccount.NdkFacebook = updatedAccount.NdkFacebook;

                return RedirectToAction(nameof(NdkIndex));
            }
            catch
            {
                return View(updatedAccount);
            }
        }


        // GET: NdkAccountController/Delete/5
        public ActionResult NdkDelete(int id)
        {
            var account = NdkListAccount.FirstOrDefault(a => a.NdkId == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }


        // POST: NdkAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdkDelete(int id, IFormCollection collection)
        {
            try
            {
                var account = NdkListAccount.FirstOrDefault(a => a.NdkId == id);
                if (account != null)
                {
                    NdkListAccount.Remove(account);
                }

                return RedirectToAction(nameof(NdkIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}