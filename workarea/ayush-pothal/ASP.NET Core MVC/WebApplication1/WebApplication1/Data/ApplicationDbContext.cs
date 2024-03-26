using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
       
                         
        }

        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Ayush", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Swayam", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Subhasish", DisplayOrder = 3 }
            );
               
               
        }
    }
}
