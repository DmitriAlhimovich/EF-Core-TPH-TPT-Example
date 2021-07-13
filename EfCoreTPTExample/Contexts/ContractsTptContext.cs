using EfCoreTPTExample.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTPTExample.Contexts
{
    public sealed class ContractsTptContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<MobileContract> MobileContracts { get; set; }
        public DbSet<TvContract> TvContracts { get; set; }
        public DbSet<BroadBandContract> BroadBandContracts { get; set; }


        public ContractsTptContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContractsTPTDB;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TvContract>().ToTable("TvContract");
            modelBuilder.Entity<MobileContract>().ToTable("MobileContract");
            modelBuilder.Entity<BroadBandContract>().ToTable("BroadBandContract");
        }
    }
}
