using BookStoreApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookStoreApp.Controllers
{
    [Authorize]
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
            string userId = GetCurrentUserId(); // Implement GetCurrentUserId() to get the current user ID
            var orders = await _context.Orders
                .Where(u=>u.UserUserID == userId)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Book)
                .ToListAsync();

            return View(orders);
        }
        private string GetCurrentUserId()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return userid;
        }
    }
}
