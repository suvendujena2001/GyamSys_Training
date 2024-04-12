namespace Api.Model
{
    public class Inventory
    {   
        public int Id { get; set; }
           public string productName { get; set; }
      public int Quantity { get; set; }
       public int CreatedBy { get; set; }
       public DateTime CreatedDate { get; set; }
      public int ModifiedBy { get; set; }
       public DateTime ModifiedDate { get; set; }
    }
}
