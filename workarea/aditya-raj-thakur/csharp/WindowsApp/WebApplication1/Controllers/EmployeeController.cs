using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();

    public IActionResult Index() //get
        {
            List<Employee> employee = db.Employees;
            return View(employee);
        }
    

    }


}
