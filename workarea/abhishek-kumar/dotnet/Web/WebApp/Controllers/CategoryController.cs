using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using Web.DataAccess.Data;
using Web.Models;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> obj = _db.Categories.ToList();

            return View(obj);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj) //for submitting the create button
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Display order cannot be same as name");
            }
            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Invalid value");
            }
            if (ModelState.IsValid) //for the condition to match
            {
                _db.Categories.Add(obj); 
                _db.SaveChanges();
                TempData["success"] = "Ctaegory created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
      

        public IActionResult Edit(int ? id)
        {
            if (id == null || id == 0) {
            return NotFound();
                    }
             Category ? category = _db.Categories.FirstOrDefault(c => c.Id == id);
           
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {

                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Ctaegory updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? category = _db.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost , ActionName("Delete")]

        public IActionResult Delete1(int ? id)

        {
          Category ? category = _db.Categories.Find( id);
            if (category == null)
            {
                return NotFound();
            }
            _db?.Categories.Remove(category);
            _db.SaveChanges();
            TempData["success"] = "Ctaegory deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
