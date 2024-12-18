using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public  int  Age { get; set; }
        public double Salary { get; set; }

        public string Position { get; set; }

        public Person(){}

        public Person(Guid id, string name, string surname, int age, double salary,string position)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Position = position;
        }
    }
}


