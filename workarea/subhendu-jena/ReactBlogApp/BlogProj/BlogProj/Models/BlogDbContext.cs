namespace BlogProj.Models;
using Microsoft.EntityFrameworkCore;

public class BlogDbContext : DbContext
{


    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {

    }

    public DbSet<Blog> Blogs { get; set; }
}


