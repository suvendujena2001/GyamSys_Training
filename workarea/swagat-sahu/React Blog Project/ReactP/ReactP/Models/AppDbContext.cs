using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ReactP.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Blogs> Blogs { get; set; }

    }
}
