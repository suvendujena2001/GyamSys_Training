using ExamAdda.Models;
using Microsoft.EntityFrameworkCore;    
using WEBAPICodeFirst.Models;

namespace WEBAPICodeFirst.Models
{
    public class ApplicatiobDbcontext: DbContext
    {
        public ApplicatiobDbcontext(DbContextOptions<ApplicatiobDbcontext>options):base(options) 
        
        {


        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }


        public DbSet<Student> Students { get; set; }

        public DbSet<Exam> Exams { get; set; }
             public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }


    }
}
