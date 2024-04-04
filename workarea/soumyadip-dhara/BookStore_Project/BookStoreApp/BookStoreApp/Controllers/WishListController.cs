using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;
using BookStoreApp.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    public class WishListController : Controller
    {
        private readonly BookStoreAppContext _context;

        public WishListController(BookStoreAppContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            // Retrieve the wishlist items for the current user
            int userId = GetCurrentUserId(); // Implement GetCurrentUserId() to get the current user ID
            var wishlistItems = _context.Wishlists
                .Include(w => w.Book)
                .Where(w => w.UserID == userId)
                .ToList();

            return View(wishlistItems);
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishList(int id)
        {
            // Get the current user ID (You may need to implement this method)
            int userId = GetCurrentUserId();

            // Check if the book is already in the wishlist for the user
            var existingWishlistItem = await _context.Wishlists.FirstOrDefaultAsync(w => w.UserID == userId && w.BookID == id);

            if (existingWishlistItem != null)
            {
                // Book already exists in the wishlist
                return RedirectToAction("Index", "HomeCard"); // Redirect to home page or wherever appropriate
            }

            // If the book doesn't exist in the wishlist, add it
            var wishlistItem = new Wishlist
            {
                UserID = userId,
                BookID = id
            };

            _context.Wishlists.Add(wishlistItem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "HomeCard"); // Redirect to home page or wherever appropriate
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(int id)
        {
            var wishlistItem = await _context.Wishlists.FindAsync(id);
            if (wishlistItem == null)
            {
                return NotFound();
            }

            _context.Wishlists.Remove(wishlistItem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index","WishList");
        }

        private int GetCurrentUserId()
        {
            // Implement logic to get the current user ID
            // For demonstration purposes, returning a dummy user ID
            return 1;
        }
    }
}
