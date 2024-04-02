namespace MVC_1.Models
{
    public class MemebershipType
    {
        public byte Id { get; set; }    
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set;}

    }
}
