using LogIn_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogIn_MVC.Controllers
{
    public class EmployeeController : Controller
    {  EmployeeDbContext db=new EmployeeDbContext();
        public IActionResult Index()
        {
            List<Employee> employee = db.employees;
            return View(employee);
        }

        

    }

}
