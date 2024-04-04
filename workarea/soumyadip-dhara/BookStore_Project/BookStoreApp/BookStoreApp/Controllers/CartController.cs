using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;
using BookStoreApp.Data;

public class CartController : Controller
{
    private readonly ICartService _cartService;
    private readonly BookStoreAppContext _context;

    public CartController(ICartService cartService, BookStoreAppContext context)
    {
        _cartService = cartService;
        _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        int userId = GetCurrentUserId();
        var carts = await _context.Carts
            .Where(c => c.UserID == userId)
            .Include(c => c.Book)
            .ToListAsync();

        return View(carts);
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart(int id)
    {
        int userId = GetCurrentUserId();

        var wishlistItem = await _context.Wishlists.FirstOrDefaultAsync(w => w.UserID == userId && w.BookID == id);
        if (wishlistItem != null)
        {
            await _cartService.AddToCartAsync(userId, id);
            _context.Wishlists.Remove(wishlistItem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","WishList");
        }

        await _cartService.AddToCartAsync(userId, id);
        return RedirectToAction("Index", "HomeCard");
    }
   
    private int GetCurrentUserId()
    {
        return 1;
    }

    [HttpPost]
    public async Task<IActionResult> UpdateQuantity(int id, int quantity)
    {
        var bookid = id;
        var cartItem = await _context.Carts.FirstOrDefaultAsync(c => c.BookID == id);

        if (cartItem == null)
        {
            return NotFound();
        }

        cartItem.Quantity = quantity;
        _context.Carts.Update(cartItem);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> RemoveFromCart(int id)
    {
        var cartItem = await _context.Carts.FirstOrDefaultAsync(c => c.BookID == id);

        if (cartItem == null)
        {
            return NotFound();
        }

        _context.Carts.Remove(cartItem);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}
