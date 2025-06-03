using Microsoft.AspNetCore.Mvc;
using NdkLesson07.Models;

namespace NdkLesson07.Controllers
{
    public class NdkEmployeeController : Controller
    {
        private static List<NdkEmployee> NdkListEmployee = new List<NdkEmployee>
        {
            new NdkEmployee
            {
                NdkId = 1,
                NdkName = "Nguyễn Duy Khánh",
                NdkBirthDay = new DateTime(2005, 1, 13),
                NdkEmail = "duykhanhduong088@gmail.com",
                NdkPhone = "0345865380",
                NdkSalary = 12000000m,
                NdkStatus = true
            },
            new NdkEmployee
            {
                NdkId = 2,
                NdkName = "Nguyễn Thị Lan",
                NdkBirthDay = new DateTime(1990, 11, 15),
                NdkEmail = "nguyen.lan@example.com",
                NdkPhone = "0987123456",
                NdkSalary = 15000000m,
                NdkStatus = true
            },
            new NdkEmployee
            {
                NdkId = 3,
                NdkName = "Lê Văn Minh",
                NdkBirthDay = new DateTime(1988, 3, 22),
                NdkEmail = "le.minh@example.com",
                NdkPhone = "0905123456",
                NdkSalary = 13500000m,
                NdkStatus = true
            },
            new NdkEmployee
            {
                NdkId = 4,
                NdkName = "Phạm Thùy Dung",
                NdkBirthDay = new DateTime(1995, 7, 10),
                NdkEmail = "pham.dung@example.com",
                NdkPhone = "0938123123",
                NdkSalary = 16500000m,
                NdkStatus = false
            },
            new NdkEmployee
            {
                NdkId = 5,
                NdkName = "Đỗ Quang Hùng",
                NdkBirthDay = new DateTime(1985, 12, 5),
                NdkEmail = "do.hung@example.com",
                NdkPhone = "0912345876",
                NdkSalary = 14000000m,
                NdkStatus = true
            }
        };
        public IActionResult NdkIndex()
        {
            return View(NdkListEmployee);
        }

        public IActionResult NdkDetails(int id)
        {
            var emp = NdkListEmployee.FirstOrDefault(x => x.NdkId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public IActionResult NdkCreate()
        {
            return View(new NdkEmployee());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NdkCreate(NdkEmployee emp)
        {
            if (!ModelState.IsValid) return View(emp);
            emp.NdkId = NdkListEmployee.Max(x => x.NdkId) + 1;
            NdkListEmployee.Add(emp);
            return RedirectToAction(nameof(NdkIndex));
        }

        public IActionResult NdkEdit(int id)
        {
            var emp = NdkListEmployee.FirstOrDefault(x => x.NdkId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NdkEdit(int id, NdkEmployee emp)
        {
            if (!ModelState.IsValid) return View(emp);
            var index = NdkListEmployee.FindIndex(x => x.NdkId == id);
            if (index == -1) return NotFound();
            emp.NdkId = id;
            NdkListEmployee[index] = emp;
            return RedirectToAction(nameof(NdkIndex));
        }

        public IActionResult Delete(int id)
        {
            var emp = NdkListEmployee.FirstOrDefault(x => x.NdkId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var emp = NdkListEmployee.FirstOrDefault(x => x.NdkId == id);
            if (emp != null) NdkListEmployee.Remove(emp);
            return RedirectToAction(nameof(NdkIndex));
        }
    }
}