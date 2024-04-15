using Microsoft.EntityFrameworkCore;

namespace BlogApi.Model
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
