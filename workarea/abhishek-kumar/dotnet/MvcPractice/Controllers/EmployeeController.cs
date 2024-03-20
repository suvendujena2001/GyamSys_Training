using Microsoft.AspNetCore.Mvc;

namespace MvcPractice.Controllers
{
    public class EmployeeController : Controller
    {
        Models.EmployeeDbContext db = new Models.EmployeeDbContext();

        public IActionResult Index() //get
        {
            List<Models.Employee> employee = db.Employees;
            return View(employee);
        }
        public ActionResult Details(int id)
        {
            List<Models.Employee> employee = db.Employees;
            return View("Index", employee);
        }
    }
}
