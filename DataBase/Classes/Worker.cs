using DataBase.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Worker : Person, IWorker
    {
        public List<Operations> operations=new List<Operations>();
        public Worker(Guid id, string name, string surname, int age, double salary, string position) : base(id, name, surname, age, salary, position)
        { 
            operations = new List<Operations>(); 
        }

        public void Add_Operations(Operations operations)
        {
            Console.WriteLine("Operation add");
        }
    }
}


        

