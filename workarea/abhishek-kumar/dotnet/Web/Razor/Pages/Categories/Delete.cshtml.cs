using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Category? Category { get; set; }
        public DeleteModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null || id != 0)
            {
                Category = _db.Categories.Find(id);
            }


        }
        public IActionResult OnPost(int ? id)
        {
            Category? category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _db?.Categories.Remove(category);
            _db.SaveChanges();
           
            return RedirectToPage("Index");
        }
    }
}
