using System.ComponentModel.DataAnnotations;

namespace MotoRepair.Models
{
    public class SignupDetails
    {
       
        public string UserName { get; set; }
        
        public string Password { get; set; }
      
        public string UserType {  get; set; }
    }
}
