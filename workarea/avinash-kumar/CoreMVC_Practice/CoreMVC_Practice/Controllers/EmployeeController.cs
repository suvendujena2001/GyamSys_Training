using CoreMVC_Practice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext dbcontext=new EmployeeDbContext();

        // GET: EmployeeController1
        public ActionResult Index()
        {
            List<Employee> employees = dbcontext.Employees; 
            return View(employees);
        }

        // GET: EmployeeController1/Details/5
        
        public ActionResult Details(int id)
        {
            List<Employee> employees = dbcontext.Employees;
            return View("Index",employees);
        }

        // GET: EmployeeController1/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
