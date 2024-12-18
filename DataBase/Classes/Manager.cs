using DataBase.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Manager : Person, IManager
    {
        public Manager(Guid id, string name, string surname, int age, double salary, string position) : base(id, name, surname, age, salary, position){}

        public void Organize()
        {
            Console.WriteLine("Organize successfully");
        }

        public void Calculate_Salaries()
        {
            Console.WriteLine("Salaries successfully");
        }
    }
}
