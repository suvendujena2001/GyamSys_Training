using System.ComponentModel.DataAnnotations;

namespace ReactP.Models
{
    public class Blogs
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
