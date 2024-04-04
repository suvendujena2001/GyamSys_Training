namespace WEBAPICodeFirst.Models
{
    public class Admin
    {
        public int AdminId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; } 

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }
    }
}
