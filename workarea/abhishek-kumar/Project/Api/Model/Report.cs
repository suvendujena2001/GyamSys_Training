namespace Api.Model
{
    public class Report
    {
        public int Id { get; set; }
          public int MechanicId { get; set; }
      public int  VehicleId { get; set; }
       public DateTime TimeStarted { get; set; }
      public DateTime TimeCompleted { get; set; }
       public DateTime Date {  get; set; }
        public int Odometer { get; set; }
       
       public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
      public int ModifiedBy { get; set; }
      public DateTime ModifiedDate { get; set; }
    }
}
