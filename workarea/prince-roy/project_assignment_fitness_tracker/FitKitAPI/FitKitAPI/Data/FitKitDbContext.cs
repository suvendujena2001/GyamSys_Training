using FitKitAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FitKitAPI.Data
{
    public class FitKitDbContext : DbContext
    {
        public FitKitDbContext(DbContextOptions<FitKitDbContext> options) : base(options) { }

        public DbSet<Workout> WorkoutTable { get; set; }

        public DbSet<Activity> ActivityTable { get; set; }

        public DbSet<Goal> Goal { get; set; } = default!;

        public DbSet<UserDetails> UserDetails { get; set; } = default!;

        public DbSet<Nutrition> Nutrition { get; set; } = default!;

        public DbSet<UserCredential> UserCredential { get; set; } = default!;

    }
}
