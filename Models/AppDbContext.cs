using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<CrimeManagementSystem.Models.Crime> Crimes { get; set; }
        public DbSet<CrimeManagementSystem.Models.Criminal> Criminals { get; set; }
        public DbSet<CrimeManagementSystem.Models.Officer> Officers { get; set; }
        public DbSet<CrimeManagementSystem.Models.Victim> Victims { get; set; }
    }
}