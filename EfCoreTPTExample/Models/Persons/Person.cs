using System;

namespace EfCoreExample.Models.Persons
{
    public abstract class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Student : Person
    {
        public string Group { get; set; }
        public byte Course { get; set; }
    }

    public class Teacher : Person
    {
        public string Topic { get; set; }
    }
}
