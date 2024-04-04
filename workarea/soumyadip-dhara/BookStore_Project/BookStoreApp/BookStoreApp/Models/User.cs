﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BookStoreApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [ValidateNever]
        public ICollection<Cart> Carts { get; set; }
        [ValidateNever]
        public ICollection<Order> Orders { get; set; }
        [ValidateNever]
        public ICollection<Wishlist> Wishlists { get; set; }
    }

}
