using ASP.NET_Task.Contexts;
using ASP.NET_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Task.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();

            return View(employees);
        }
    }
}
