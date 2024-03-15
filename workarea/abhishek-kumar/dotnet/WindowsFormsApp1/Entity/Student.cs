namespace WindowsFormsApp1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        [Column("Student", Order = 0)]
        [StringLength(50)]
        public string Student1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RegdNo { get; set; }
    }
}
