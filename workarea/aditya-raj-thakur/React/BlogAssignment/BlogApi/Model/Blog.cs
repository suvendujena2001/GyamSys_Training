using System.ComponentModel.DataAnnotations;

namespace BlogApi.Model
{
    public class Blog
    {
        [Key]
        public int BlogId {get; set;}
        public string Title { get; set;}
        public string Description { get; set;}
    }
}
