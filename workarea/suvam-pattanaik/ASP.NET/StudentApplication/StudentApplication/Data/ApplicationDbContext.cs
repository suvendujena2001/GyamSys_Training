﻿using Microsoft.EntityFrameworkCore;
using StudentApplication.Models.Entities;

namespace StudentApplication.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
            
        }
        public DbSet<Student> Students { get; set; }
    }
}