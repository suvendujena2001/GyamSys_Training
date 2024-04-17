﻿using Microsoft.EntityFrameworkCore;

namespace Blog_Application.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
