﻿namespace Api.Model
{
    public class Mechanic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
       public string UserName { get; set; }
        public int  CreatedBy { get; set; }
       public  DateTime CreatedDate { get; set; }
       public int ModifiedBy { get; set; }
       public DateTime ModifiedDate { get; set; }
    }
}
