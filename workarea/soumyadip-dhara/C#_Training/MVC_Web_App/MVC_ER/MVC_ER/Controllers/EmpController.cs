using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            List<Emp> emps = Context.Employees.ToList();
            return View(emps);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = Context.Employees.Find(id);

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
            if (ModelState.IsValid)
            {
                Context.Employees.Add(emp);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: EmpController/Edit/5
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

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpController/Delete/5
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
