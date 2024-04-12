namespace Api.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
         public string Model { get; set; }
        
       public int Year {  get; set; }
      public string FuelType { get; set; }
      public int Cylinders {  get; set; }
       public int NumberPlate { get; set; }
      public int CustomerId { get; set; }
      public int CreatedBy { get; set; }
       public DateTime CreatedDate { get; set; }
      public int ModifiedBy { get; set; }
       public DateTime ModifiedDate {  get; set; }
    }
}
