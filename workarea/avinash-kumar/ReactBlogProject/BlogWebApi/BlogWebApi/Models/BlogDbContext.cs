using Microsoft.EntityFrameworkCore;

namespace BlogWebApi.Models
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; } 
    }
}
