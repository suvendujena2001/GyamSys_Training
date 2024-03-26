using Microsoft.EntityFrameworkCore;
using MvcIplApp.Models;

namespace MvcIplApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, FullName = "Chennai Super Kings", Title = "CSK", Coach = "Stephen Fleming", Captain = "Ruturaj Gaikwad", Venue = "M. A. Chidambaram Stadium" },
                new Team() { Id = 2, FullName = "Delhi Capitals", Title = "DC", Coach = "Ricky Ponting", Captain = "Rishabh Pant", Venue = "Arun Jaitley Stadium" },
            new Team() { Id = 3, FullName = "Royal Challengers Bengaluru", Title = "RCB", Coach = "Sanjay Bangar", Captain = "Faf du Plessis", Venue = "M. Chinnaswamy Stadium" },
            new Team() { Id = 4, FullName = "Gujarat Titans", Title = "GT", Coach = "Ashish Nehra", Captain = "Shubman Gill", Venue = "Narendra Modi Stadium" },
            new Team() { Id = 5, FullName = "Kolkata Knight Riders", Title = "KKR", Coach = "Chandrakant Pandit", Captain = "Shreyas Iyer", Venue = "Eden Gardens" },
            new Team() { Id = 6, FullName = "Lucknow Super Giants", Title = "LSG", Coach = "Justin Langer", Captain = "KL Rahul", Venue = "BRSABV Ekana Cricket Stadium" }
            );
        }
    }
}
