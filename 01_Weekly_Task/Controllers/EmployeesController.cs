using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _01_Weekly_Task.Context;
using _01_Weekly_Task.Models;
using _01_Weekly_Task.ViewModel;

namespace _01_Weekly_Task.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly NorthwindContext _context;

        public EmployeesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index(int id)
        {
            var employee = _context.Employees.Where(e => e.EmployeeId == id).Select(b=> new EmployeeInfoViewModel
            {
                EmployeeId=b.EmployeeId,
                FirstName=b.FirstName,
                LastName=b.LastName,
                Title=b.Title,
                BirthDate = (DateTime)b.BirthDate,
                HomePhone=b.HomePhone,
                Address=b.Address

            }).ToList();
            return View(employee);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,FirstName,LastName,Title,BirthDate,HomePhone,Address")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(employee);
            }
            return View(employee);
        }
        private bool EmployeeExists(int id)
        {
          return (_context.Employees?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
        }
    }
}
