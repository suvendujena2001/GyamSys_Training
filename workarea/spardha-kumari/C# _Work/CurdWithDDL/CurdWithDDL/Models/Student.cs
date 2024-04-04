
using System.ComponentModel.DataAnnotations;

namespace CurdWithDDL.Models

{
    public class Student
    {
        [Required(ErrorMessage = "name is must")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 25")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
