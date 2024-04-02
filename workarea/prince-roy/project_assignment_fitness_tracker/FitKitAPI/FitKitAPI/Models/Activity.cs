using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class Activity
    {
        [Key]
        public int UserId { get; set; }
        public int StepsTaken { get; set; }
        public int CaloriesBurned { get; set; }
        public double DistanceCovered { get; set; }
        public double ActiveMinutes { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
