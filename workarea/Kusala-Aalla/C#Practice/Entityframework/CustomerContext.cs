using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class CustomerContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }

        //Connection String(used to connect to database)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IN-9P39GG3;Database=RankenCustomers;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Sruthi", Budget = 10000 },
                new Customer { CustomerId = 2, CustomerName = "Deepak", Budget = 15000 },
                new Customer { CustomerId = 3, CustomerName = "Priya", Budget = 30000 }
                );
        }

    }
}
