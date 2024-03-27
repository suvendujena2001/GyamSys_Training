using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemebershipType MemebershipType { get; set; }    
        public byte MemebershipTypeId { get; set; }
    }
}
