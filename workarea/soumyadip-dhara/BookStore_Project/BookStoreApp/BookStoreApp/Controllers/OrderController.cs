using BookStoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    public class OrderController : Controller
    {

        private readonly BookStoreAppContext _context;

        public OrderController(BookStoreAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Retrieve the wishlist items for the current user
            int userId = GetCurrentUserId(); // Implement GetCurrentUserId() to get the current user ID
            var orders = await _context.Orders
                .Where(u=>u.UserID == userId)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Book)
                .ToListAsync();

            return View(orders);
        }
        private int GetCurrentUserId()
        {
            return 1;
        }
    }
}
