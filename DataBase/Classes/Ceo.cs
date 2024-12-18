using DataBase.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Ceo : Person, ICeo
    {
        public Ceo(Guid id, string name, string surname, int age, double salary, string position) : base(id, name, surname, age, salary, position) {}

        public void Control()
        {
            Console.WriteLine("Control successfully");
        }

        public void Organize()
        {
            Console.WriteLine("Organize successfully");
        }

        public void Make_Meeting()
        {
            Console.WriteLine("Meeting successfully");
        }

        public void Decrease_Percentage(double percent) 
        {
            Console.WriteLine("Percent successfully");
        }

    }
}
