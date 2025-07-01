using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenDuyKhanh_2310900050.Data;
using NguyenDuyKhanh_2310900050.Models;

namespace NguyenDuyKhanh_2310900050.Controllers
{
    public class NdkEmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NdkEmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NdkEmployee
        public async Task<IActionResult> Index()
        {
            return View(await _context.NdkEmployee.ToListAsync());
        }

        // GET: NdkEmployee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var emp = await _context.NdkEmployee.FirstOrDefaultAsync(m => m.NdkEmpId == id);
            if (emp == null) return NotFound();

            return View(emp);
        }

        // GET: NdkEmployee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NdkEmployee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NdkEmpName,NdkEmpLevel,NdkEmpStartDate,NdkEmpStatus")] NdkEmployee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

        // GET: NdkEmployee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var emp = await _context.NdkEmployee.FindAsync(id);
            if (emp == null) return NotFound();

            return View(emp);
        }

        // POST: NdkEmployee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NdkEmpId,NdkEmpName,NdkEmpLevel,NdkEmpStartDate,NdkEmpStatus")] NdkEmployee emp)
        {
            if (id != emp.NdkEmpId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.NdkEmployee.Any(e => e.NdkEmpId == id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

        // GET: NdkEmployee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var emp = await _context.NdkEmployee.FirstOrDefaultAsync(m => m.NdkEmpId == id);
            if (emp == null) return NotFound();

            return View(emp);
        }

        // POST: NdkEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emp = await _context.NdkEmployee.FindAsync(id);
            _context.NdkEmployee.Remove(emp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}