using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
