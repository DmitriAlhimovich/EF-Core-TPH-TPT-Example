using EfCoreExample.Models.Employees;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTPTExample.Contexts
{
    public sealed class EmployeesContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public EmployeesContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EmployeesDB;Trusted_Connection=True;");
        }
    }
}
