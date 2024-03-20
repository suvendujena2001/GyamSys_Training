using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext dbContext = new EmployeeDbContext();

        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees;
            return View(employees);
        }

    }
}
