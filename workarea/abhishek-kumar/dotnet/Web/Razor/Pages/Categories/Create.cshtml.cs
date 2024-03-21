using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;
using Razor.Models;

namespace Razor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _appDbContext.Categories.Add(Category);

            _appDbContext.SaveChanges();
            return RedirectToPage("Index");



        }
    }
}
