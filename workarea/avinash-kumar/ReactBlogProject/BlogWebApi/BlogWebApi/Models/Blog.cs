using System.ComponentModel.DataAnnotations;

namespace BlogWebApi.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Titile { get; set; }
        public string Description { get; set; }

    }
}
