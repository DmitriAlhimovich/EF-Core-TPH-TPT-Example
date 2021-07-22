using System;
using System.Collections.Generic;

namespace EfCoreExample.Models.Employees
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        //public int DepartmentId { get; set; }
        //public Department Department { get; set; }
    }

    public class Department
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        //public List<Employee> Employees { get; set; }

    }
}
