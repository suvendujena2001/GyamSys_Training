using Microsoft.EntityFrameworkCore;

namespace BlogWebApi.Model
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options) 
        
        {

            
        }
        public DbSet<Blog> Blogs { get; set;}

    }
}
