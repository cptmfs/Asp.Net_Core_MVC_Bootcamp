using _01_Weekly_Task.Models;
using Microsoft.AspNetCore.Mvc;
using _01_Weekly_Task.Context;
using System.Diagnostics;
using _01_Weekly_Task.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace _01_Weekly_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger, NorthwindContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var employee= _context.Employees.ToList();
            return View(employee);
        }
        public IActionResult Orders(int id)
        {

            var ordersWithEmployees = _context.Orders
                    .Where(o => o.EmployeeId==id)
                    .Select(o => new OrderWithEmployeeViewModel
                    {
                        OrderId = o.OrderId,
                        OrderDate = (DateTime)o.OrderDate,
                        EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName
                    })
                    .ToList();

            return View(ordersWithEmployees);
        }

        public IActionResult Products(int orderId)
        {

            var orderDetails = _context.OrderDetails
                   .Where(od => od.OrderId == orderId)
                   .Select(od => new OrderDetailsViewModel
                   {
                       ProductName = od.Product.ProductName,
                       Quantity = od.Quantity
                   })
                   .ToList();

            return View(orderDetails);
        }

        public IActionResult PersonalInfo()
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