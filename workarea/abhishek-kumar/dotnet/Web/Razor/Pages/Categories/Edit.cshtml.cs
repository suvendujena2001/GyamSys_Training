using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.Categories

{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public EditModel(AppDbContext db)
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
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
