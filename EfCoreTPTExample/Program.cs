using System;
using System.Linq;
using EfCoreTPTExample.Contexts;
using EfCoreTPTExample.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTPTExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new UniversityDbContext())
            {
                var res = context.Students.ToList();
            }

            using (var context = new ContractsTptContext())
            {
                var tvContract = new TvContract()
                { Charge = 112, PackageType = "full", StartDate = DateTime.Now };

                var entity = context.Entry(tvContract);
                

                context.TvContracts.Add(tvContract);
                context.SaveChanges();
            }

            using (var context = new EmployeesContext())
            {
                //context.Employees
                //    .Where(e => e.DepartmentId.HasValue)
                //    .Load();
            }
        }
    }
}