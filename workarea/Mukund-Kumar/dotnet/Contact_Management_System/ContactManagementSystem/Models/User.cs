using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContactManagementSystem.Models
{
    public class User:IdentityUser
    {
        public string FullName {  get; set; }
        [ValidateNever]
        public ICollection<Contact> Contacts { get; set; }
    }
}
