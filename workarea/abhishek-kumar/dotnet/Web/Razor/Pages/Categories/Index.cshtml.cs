using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;

using Razor.Models;

namespace Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        public List<Category> CategoryList{ get; set; }
        public IndexModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void OnGet()
        {
            CategoryList = _appDbContext.Categories.ToList();
        }
    }
}
