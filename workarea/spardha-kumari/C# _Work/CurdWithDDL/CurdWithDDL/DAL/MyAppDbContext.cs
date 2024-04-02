using Microsoft.EntityFrameworkCore;
using CurdWithDDL.Models;
namespace CurdWithDDL.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {

           
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> MyProperty { get; set; }

    }
}
