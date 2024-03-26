
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.DataAccess.Data
{
    public class AppDbContext  : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }

                );
           
            modelBuilder.Entity<User>().HasData(
                new User { Id=1, UserName = "Abhishek", Password = "Abhi"},
                new User { Id = 2,UserName = "Aditya", Password = "Adi" },
                new User { Id = 3, UserName = "Prince", Password = "Pri" }
            );
        }

       

    }
}
