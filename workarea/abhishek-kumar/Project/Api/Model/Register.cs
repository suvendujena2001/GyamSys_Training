using Azure.Identity;

namespace Api.Model
{
    public class Register
    {
        public  string UserName {  get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserType { get; set; }
    }
}
