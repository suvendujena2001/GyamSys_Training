using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    [Authorize]
    public class HomeCardController : Controller
    {
        private readonly BookStoreAppContext _context;
        public HomeCardController(BookStoreAppContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var bookStoreAppContext = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.User);
            return View(await bookStoreAppContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);

        }


        }
}
