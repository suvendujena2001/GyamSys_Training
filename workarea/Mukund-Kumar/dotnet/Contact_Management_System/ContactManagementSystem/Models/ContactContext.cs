using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ContactManagementSystem.Models;

public class ContactContext : IdentityDbContext<User>
{
    public ContactContext(DbContextOptions<ContactContext> options):base(options)
    { }
    public DbSet<User>Users { get; set; }
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    // these are the two tables inside our database 

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Category>().HasData(
    //        new Category { CategoryID = 1, CategoryName = "Family" },
    //        new Category { CategoryID = 2, CategoryName = "Friends" },
    //        new Category { CategoryID = 3, CategoryName = "Work" });

    //    modelBuilder.Entity<Contact>().HasData(
    //        new Contact
    //        {
    //            Id = 1,
    //            CategoryID = 2,
    //            FirstName = "Mukund",
    //            LastName = "Kumar",
    //            PhoneNumber = "8498906235",
    //            Email = "mukundkumar23.mk@gmail.com"            
    //        },

    //        new Contact
    //        {
    //            Id = 2,
    //            CategoryID = 2,
    //            FirstName = "Soumyadip",
    //            LastName = "Dhara",
    //            PhoneNumber = "8734658987",
    //            Email = "soumyadipdhara67@gmail.com"              
    //        }
    //        );
    //}
}
