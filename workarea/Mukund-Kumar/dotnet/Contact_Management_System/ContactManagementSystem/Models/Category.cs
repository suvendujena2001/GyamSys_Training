using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementSystem.Models
{
    public class Category
    {
        
        public int CategoryID{ get; set; }

        [Required]
        public string CategoryName { get; set; } = null!;
}
}
