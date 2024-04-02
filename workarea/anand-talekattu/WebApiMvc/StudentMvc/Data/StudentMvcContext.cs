using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMvc.Models;

namespace StudentMvc.Data
{
    public class StudentMvcContext : DbContext
    {
        public StudentMvcContext (DbContextOptions<StudentMvcContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMvc.Models.Student> Student { get; set; } = default!;
    }
}
