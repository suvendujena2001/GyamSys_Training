using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MVC_1.Models
{
    public class MVC_1DbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = IN-328PLG3\\SQLEXPRESS; Initial Catalog = MVC-1; User ID = sa; Password = sa; Trust Server Certificate = True");
        }
    }
}
