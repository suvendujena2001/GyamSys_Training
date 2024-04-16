
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Model
{
    public class ClassDbContext:DbContext
    { 
       public  ClassDbContext(DbContextOptions<ClassDbContext> options) : base(options) {
        }
        public DbSet<Blog> Blogs { get; set; }  
    }
}
