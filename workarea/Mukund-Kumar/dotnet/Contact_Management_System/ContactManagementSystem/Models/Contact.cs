using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementSystem.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter First Name: ")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Enter Last Name: ")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Enter Phone Number: ")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Enter  Email: ")]
        public string Email { get; set; } = null!;

        // for category table
        [Required(ErrorMessage ="Please select a Category")]
        public int? CategoryID { get; set; }

        public string UserID { get; set; }

        // navigation property
        [ValidateNever]
        public Category Category { get; set; } = null!;

        [ValidateNever]
        public User User { get; set; }

       

        

        

        // Read only property that returns full name of the contact
        public string Slug => (FirstName ?? "").Replace(' ', '-').ToLower() + '-' + (LastName ?? "").Replace(" ", "-").ToLower();



    }
}
