using System.ComponentModel.DataAnnotations;

namespace MvcIplApp.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FullName { get; set; }  
        public string Coach { get; set; }
        public string Captain { get; set; }
        public string Venue { get; set; }
        
    }
}
