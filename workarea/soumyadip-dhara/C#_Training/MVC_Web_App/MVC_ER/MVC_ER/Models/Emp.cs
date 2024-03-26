using System.ComponentModel.DataAnnotations;

namespace MVC_ER.Models
{
    public class Emp
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Position { get; set; }
        public int? Salary { get; set; }
        public string? EmailId {  get; set; }
        public string Phone { get; set; }
    }
}
