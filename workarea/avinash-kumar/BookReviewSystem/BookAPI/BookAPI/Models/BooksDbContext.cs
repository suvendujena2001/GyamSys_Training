using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class BooksDbContext:DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Stat> Stats { get; set; }

        public DbSet<User> Users { get; set; }




    }
}
