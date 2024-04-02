using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_Forms_EntityFramework
{
    public partial class WindowsForms1 : DbContext
    {
        public WindowsForms1()
            : base("name=WindowsForms1")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
