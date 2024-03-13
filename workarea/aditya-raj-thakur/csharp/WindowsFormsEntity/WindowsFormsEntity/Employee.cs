namespace WindowsFormsEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal EmpId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string EmpName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Edesignation { get; set; }
    }
}
