using Microsoft.AspNetCore.Mvc;

namespace FitKitAPI.Models
{
    public class UserClaimsModel
    {
        public string UserId { get; set; }

        public string EmailAddress { get; set; }

        public string GivenName { get; set; }

        public string Surname { get; set; }

        internal ActionResult<IEnumerable<UserClaimsModel>> toListAsync()
        {
            throw new NotImplementedException();
        }
    }

}
