using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace BookAPI.Models
{
    public class Stat
    {
        [Key]
        public int StatsId { get; set; }
        public int Likes { get; set; }
        public string Comments { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        public String ISBN { get; set; }
        public int UserId { get; set; }
        

    }
}
