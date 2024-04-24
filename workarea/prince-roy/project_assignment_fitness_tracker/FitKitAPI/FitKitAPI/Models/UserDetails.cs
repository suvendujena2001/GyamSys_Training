using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public string FitnessGoals { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        internal ActionResult<IEnumerable<UserDetails>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
