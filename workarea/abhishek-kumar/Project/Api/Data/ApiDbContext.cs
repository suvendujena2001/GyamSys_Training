using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base (options)
        {
            
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
         public DbSet<Report> Reports { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Inventory > Inventories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
