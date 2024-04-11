using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int AuthorID {  get; set; }
        public string AuthorName { get; set; }
        public int GenreID {  get; set; }
        public string GenreName { get; set; } 

        public string CoverImage {  get; set; }
        public decimal Price { get; set; }
        public int Page {  get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Popularity {  get; set; }
        public bool Availability { get; set; }

        public string UserUserId {  get; set; }
        public DateTime CreatedDate {  get; set; }
        public DateTime UpdatedDate { get; set; }

        [ValidateNever]
        public virtual Author Author { get; set; }
        [ValidateNever]
        public User User { get; set; }
        [ValidateNever]
        public Genre Genre { get; set; }
        [ValidateNever]
        public ICollection<Cart> Carts { get; set; }
        [ValidateNever]
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [ValidateNever]
        public ICollection<Wishlist> Wishlists { get; set; }

    }

}
