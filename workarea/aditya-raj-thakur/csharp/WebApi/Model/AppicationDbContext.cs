using Microsoft.EntityFrameworkCore;

namespace WebApi.Model
{
    public class AppicationDbContext:DbContext
    {
        public AppicationDbContext(DbContextOptions<AppicationDbContext> options):base(options) {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                UserName = "Adi",
                Password = "Adi",
                Email = "Adi.@gmail.com",
                DateOfBirth = new DateTime(2001, 07, 09),
                Gender="Male"
            },new User
            {
                UserId = 2,
                UserName="Abhi",
                Password="Abhi",
                Email="Abhi.@gmail.com",
                DateOfBirth = new DateTime(2001,12,30),
                Gender = "Male"


            });
        }
    }
}
