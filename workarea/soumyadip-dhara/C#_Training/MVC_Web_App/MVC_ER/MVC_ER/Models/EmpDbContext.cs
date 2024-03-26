using Microsoft.EntityFrameworkCore;

namespace MVC_ER.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {

        }
        public DbSet<Emp> Employee { get; set; }
    }

}
