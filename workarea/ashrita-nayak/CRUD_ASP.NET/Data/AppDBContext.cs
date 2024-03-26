using CRUD_ASP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)

        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
