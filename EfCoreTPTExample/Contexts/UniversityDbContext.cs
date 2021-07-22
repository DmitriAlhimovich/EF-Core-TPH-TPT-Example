using EfCoreExample.Models.Persons;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTPTExample.Contexts
{
    public sealed class UniversityDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public UniversityDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=University;Trusted_Connection=True;");
        }
    }
}
