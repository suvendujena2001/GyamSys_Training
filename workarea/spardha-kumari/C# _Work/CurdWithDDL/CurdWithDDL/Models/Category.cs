using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CurdWithDDL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Category")]
        public string Name { get; set; }

    }
}
