using System.ComponentModel.DataAnnotations;

namespace ExamAdda.Models
{
    public class LoginDetails
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
