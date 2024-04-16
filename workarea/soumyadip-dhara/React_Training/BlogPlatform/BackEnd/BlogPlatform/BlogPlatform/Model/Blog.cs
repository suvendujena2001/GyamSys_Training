using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Model
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Description {  get; set; }
        public string Image {  get; set; }
    }
}
