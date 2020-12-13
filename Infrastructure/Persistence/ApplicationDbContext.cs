using CasinoLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    class ApplicationDbContext : DbContext    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyEntry> CompanyEntries { get; set; }
        public DbSet<CompanyEntryStaging> CompanyEntriesStaging { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Default Values
            modelBuilder.Entity<Company>().Property(e => e.DateAdded).HasDefaultValue("getdate()");
            modelBuilder.Entity<Employee>().Property(e => e.isActive).HasDefaultValue(1);




        }

    }
}
