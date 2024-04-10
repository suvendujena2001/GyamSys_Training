using Microsoft.EntityFrameworkCore;
using WEBAPICodeFirst.Models;

namespace ExamAdda.Models
{
    public class ExamDbcontext:DbContext
    {
        public ExamDbcontext(DbContextOptions<ExamDbcontext> options) : base(options) { }
      
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
