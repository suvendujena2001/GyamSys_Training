using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPICodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }
        [DefaultValue(false)]
        public bool? Active { get; set; }

    }
}
