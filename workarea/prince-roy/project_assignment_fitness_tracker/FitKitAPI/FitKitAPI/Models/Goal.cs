using System.ComponentModel.DataAnnotations;

namespace FitKitAPI.Models
{
    public class Goal
    {
        [Key]
        public int UserId { get; set; }
        public double WeightLoss { get; set; }
        public double MuscleGain { get; set; }
        public double EnduranceMovement { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
