using CoreMVC_Practice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeDbContext DbContext { get; }

        //EmployeeDbContext dbcontext=new EmployeeDbContext();
        public EmployeeController(EmployeeDbContext dbContext) {
            DbContext = dbContext;
        }
        // GET: EmployeeController1
        public ActionResult Index()
        {
           List<Employee> employees = DbContext.Employees.ToList(); 
            return View(employees);
        }

        // GET: EmployeeController1/Details/5
        
        public ActionResult Details(int? id)
        {
            List<Employee> employees = DbContext.Employees.Where(e=> e.Id==id).ToList();
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
        public ActionResult Create(Employee obj)
        {
                if (ModelState.IsValid)
                {
                    DbContext.Employees.Add(obj);
                    DbContext.SaveChanges();
                    return RedirectToAction("Index", "Employee");
                }
            return View();
            
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int? id)
        {
            Employee emp = DbContext.Employees.Find(id); 
            return View(emp);
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
