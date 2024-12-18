using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Client:Person
    {
        public string Name_Address { get; set; }
        public string Work_Address { get; set; }

        public Client(){}

        public Client(Guid id, string name, string surname, int age, double salary, string position,string name_address,string work_address) : base(id, name, surname, age, salary, position)
        {
           Name_Address = name_address;
           Work_Address = work_address;
        }
    }
}



