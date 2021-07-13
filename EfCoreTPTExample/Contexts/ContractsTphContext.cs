using EfCoreTPTExample.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTPTExample.Contexts
{
    public sealed class ContractsTphContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<MobileContract> MobileContracts { get; set; }
        public DbSet<TvContract> TvContracts { get; set; }
        public DbSet<BroadBandContract> BroadBandContracts { get; set; }


        public ContractsTphContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContractsDB;Trusted_Connection=True;");
        }
    }
}
