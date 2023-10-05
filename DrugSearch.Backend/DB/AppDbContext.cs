using DrugSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugSearch.DB
{
    public class AppDbContext : DbContext
    {
        private IConfiguration _configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugStore> DrugStores { get; set; }
        public DbSet<DrugPriceInDrugStore> DrugPriceInDrugStores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration["DbConnDigitalOcean"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AppDbConfig(modelBuilder).Configure();
        }
    }
}
