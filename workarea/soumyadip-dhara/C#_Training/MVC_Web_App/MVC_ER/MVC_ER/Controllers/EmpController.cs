using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_ER.Models;

namespace MVC_ER.Controllers
{
    public class EmpController : Controller
    {
        public EmpDbContext Context { get; }
        public EmpController(EmpDbContext context)
        {
            Context = context;
        }

        // GET: EmpController
        public IActionResult Index()
        {
            var emps = Context.Employee.ToList();
            //List<Emp> emps = Context.Employees.ToList();
            return View(emps);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = Context.Employee.Find(id);

            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // GET: EmpController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Emp emp)
        {

            if (!Context.Employee.Any(e => e.Id == emp.Id))
            {
                Context.Employee.Add(emp);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("ID", "This ID already exists");
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int? id)
        {
            var emp = Context.Employee.Find(id);

            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
                var employee = Context.Employee.Find(id);

                if (employee == null)
                {
                    return NotFound();
                }

                // Update the employee's properties with the values from the `IFormCollection`
                employee.Name = collection["Name"];
                employee.Position = collection["Position"];
                employee.Salary = int.Parse(collection["Salary"]);
                employee.EmailId = collection["EmailId"];
                employee.Phone = collection["phone"];



                // Save the updated employee back to the database
                Context.SaveChanges();

                // Add a success message to the `TempData` dictionary
                TempData["Message"] = "Employee updated successfully.";

                return RedirectToAction(nameof(Index));
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = Context.Employee.Find(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var emp= Context.Employee.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            Context.Employee.Remove(emp);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
