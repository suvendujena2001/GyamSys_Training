using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp2.Models
{
    public partial class EntityFrameWork : DbContext
    {
        public EntityFrameWork()
            : base("name=EntityFrameWork")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Person);
        }
    }
}
