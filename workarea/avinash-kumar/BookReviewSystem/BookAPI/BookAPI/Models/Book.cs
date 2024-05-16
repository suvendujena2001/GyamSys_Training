using BookAPI.Controllers;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
    public class Book
    {
        [Key]
        public String ISBN { get; set; }
        public String BookTitle { get; set; }
        public String BookAuthor {  get; set; }
        public String YearOfPublication { get; set; }
        public String Publisher { get; set; }   
        public String ImageUrl_S { get; set; }
        public String ImageUrl_M { get; set; }
        public String ImageUrl_L { get; set; }
        public int TotalLikes { get; set; }
        public double AverageRating { get; set; }


    }
}
