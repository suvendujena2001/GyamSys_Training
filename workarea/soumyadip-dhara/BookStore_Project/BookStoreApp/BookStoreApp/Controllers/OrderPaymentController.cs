﻿using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    public class OrderPaymentController : Controller
    {
        private readonly BookStoreAppContext _context;
        public OrderPaymentController(BookStoreAppContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Payment(decimal totalAmount)
        {
            int userId = GetCurrentUserId();

            // Retrieve user details from the database using the user ID
            var user = await _context.Users.FindAsync(userId);

            // Pass the user details and total amount to the view
            ViewBag.User = user;
            ViewBag.TotalAmount = totalAmount;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Purchase()
        {
            // Get the current user ID
            int userId = GetCurrentUserId();

            // Retrieve items from the cart for the current user
            var cartItems = await _context.Carts
                .Include(c => c.Book)
                .Where(c => c.UserID == userId)
                .ToListAsync();

            // Create a new order
            var order = new Order
            {
                UserID = userId,
                OrderDate = DateTime.Now,
                TotalAmount = cartItems.Sum(c => c.Quantity * c.Book.Price),
                Status = "Dispatched" // You can set the initial status as needed
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Create order details for each item in the cart
            foreach (var cartItem in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = order.OrderID,
                    BookID = cartItem.BookID,
                    Quantity = cartItem.Quantity,
                    UnitPrice = cartItem.Book.Price
                };

                _context.OrderDetails.Add(orderDetail);
            }

            // Remove items from the cart
            _context.Carts.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            // Redirect to the payment page or any other page as needed
            return Json(new { success = true });
        }

        private int GetCurrentUserId()
        {
            return 1;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
