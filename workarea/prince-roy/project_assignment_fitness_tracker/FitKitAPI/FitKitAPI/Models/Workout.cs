using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class Workout
    {
        [Key]
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public string ExerciseType { get; set; }
        public double Duration { get; set; }
        public double Intensity { get; set; }
        public double Sets { get; set; }
        public double Repeatitions { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
