using Microsoft.AspNetCore.Mvc;
using NdkLab06.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NdkLab06.Controllers
{
    public class NdkEmployeeController : Controller
    {
        public static List<NdkEmployee> ndkListEmployee = new List<NdkEmployee>
        {
            new NdkEmployee
            {
                ndkId = 1,
                ndkName = "Nguyễn Duy Khánh",
                ndkBirthDay = new DateTime(2005, 1, 13),
                ndkEmail = "duykhanhduong088@gmail.com",
                ndkPhone = "0345865380",
                ndkSalary = 15000000,
                ndkStatus = true
            },
            new NdkEmployee
            {
                ndkId = 2,
                ndkName = "Trần Thị Bích",
                ndkBirthDay = new DateTime(2001, 3, 10),
                ndkEmail = "tranbichbich@gmail.com",
                ndkPhone = "0123456782",
                ndkSalary = 12000000,
                ndkStatus = false
            },
            new NdkEmployee
            {
                ndkId = 3,
                ndkName = "Lê Văn Cường",
                ndkBirthDay = new DateTime(1999, 8, 25),
                ndkEmail = "lecuong@gmail.com",
                ndkPhone = "0123456783",
                ndkSalary = 13000000,
                ndkStatus = true
            },
            new NdkEmployee
            {
                ndkId = 4,
                ndkName = "Phạm Quang Dũng",
                ndkBirthDay = new DateTime(1998, 11, 15),
                ndkEmail = "phamdung@gmail.com",
                ndkPhone = "0123456784",
                ndkSalary = 11000000,
                ndkStatus = true
            },
            new NdkEmployee
            {
                ndkId = 5,
                ndkName = "Hoàng Thị Em",
                ndkBirthDay = new DateTime(2002, 5, 5),
                ndkEmail = "hoangem@gmail.com",
                ndkPhone = "0123456785",
                ndkSalary = 14000000,
                ndkStatus = false
            }
        };

        // 1. Danh sách nhân viên
        public IActionResult NdkIndex()
        {
            return View(ndkListEmployee);
        }

        // 2. Xem chi tiết nhân viên
        public IActionResult NdkDetails(int id)
        {
            var emp = ndkListEmployee.FirstOrDefault(e => e.ndkId == id);
            if (emp == null)
                return NotFound();
            return View(emp);
        }

        // 3. Thêm nhân viên (GET)
        [HttpGet]
        public IActionResult NdkCreate()
        {
            return View();
        }

        // 4. Thêm nhân viên (POST)
        [HttpPost]
        public IActionResult NdkCreate(NdkEmployee emp)
        {
            emp.ndkId = ndkListEmployee.Max(e => e.ndkId) + 1;
            ndkListEmployee.Add(emp);
            return RedirectToAction("NdkIndex");
        }

        // 5. Sửa nhân viên (GET)
        [HttpGet]
        public IActionResult NdkEdit(int id)
        {
            var emp = ndkListEmployee.FirstOrDefault(e => e.ndkId == id);
            if (emp == null)
                return NotFound();
            return View(emp);
        }

        // 6. Sửa nhân viên (POST)
        [HttpPost]
        public IActionResult NdkEdit(NdkEmployee emp)
        {
            var e = ndkListEmployee.FirstOrDefault(x => x.ndkId == emp.ndkId);
            if (e != null)
            {
                e.ndkName = emp.ndkName;
                e.ndkBirthDay = emp.ndkBirthDay;
                e.ndkEmail = emp.ndkEmail;
                e.ndkPhone = emp.ndkPhone;
                e.ndkSalary = emp.ndkSalary;
                e.ndkStatus = emp.ndkStatus;
            }
            return RedirectToAction("NdkIndex");
        }

        // 7. Xoá nhân viên (GET)
        [HttpGet]
        public IActionResult NdkDelete(int id)
        {
            var emp = ndkListEmployee.FirstOrDefault(e => e.ndkId == id);
            if (emp == null)
                return NotFound();
            return View(emp);
        }

        // 8. Xoá nhân viên (POST)
        [HttpPost, ActionName("NdkDelete")]
        public IActionResult NdkDeleteConfirmed(int id)
        {
            var emp = ndkListEmployee.FirstOrDefault(e => e.ndkId == id);
            if (emp != null)
                ndkListEmployee.Remove(emp);
            return RedirectToAction("NdkIndex");
        }
    }
}