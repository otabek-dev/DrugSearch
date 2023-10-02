using DrugSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DrugStore> DrugStores { get; set; }
        public DbSet<Drug> Drugs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=DrugDb; Username=postgres; Password=5437721o");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AppDbConfig(modelBuilder).Configure();
        }
    }
}
