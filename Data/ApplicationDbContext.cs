using Microsoft.EntityFrameworkCore;
using MoodTrackerApp.Models;

namespace MoodTrackerApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<MoodEntry> MoodEntries { get; set; }
    }
}
