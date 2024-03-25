using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeDbContext Context { get; }

        public EmployeeController(EmployeeDbContext dbcontext)
        {
            Context = dbcontext;
        }
        public IActionResult Index() //get
        {
            List<Employee> employee = Context.Employees.ToList();
            return View(employee);
        }
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                Context.Employees.Add(obj);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Edit(int?id) { 
            Employee emp=Context.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                Context.Employees.Update(emp);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }



    }
}
