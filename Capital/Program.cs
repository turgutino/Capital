using DataBase;
using DataBase.Classes;
using DataBase.InterFace;
using System.Collections.Generic;

namespace Capital
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Ceo ceo = new Ceo(Guid.NewGuid(), "Qoshqar", "Sofuyev", 42, 15000,"Ceo");
            ceo.Make_Meeting();

            Manager manager = new Manager(Guid.NewGuid(), "Elmir", "Sofuyev", 23, 6500, "Engineer");
            Worker worker = new Worker(Guid.NewGuid(), "Turgut", "Sofuyev", 19, 4000, "Developer");
            Operations op1 = new Operations(Guid.NewGuid(), "Credit operations", new DateTime(2024, 12, 12));
            worker.Add_Operations(op1);


            Bank bank = new Bank{Name = "Capital",Budget = 23487200,Profit = 6500000,Workers = new List<Worker> { worker },  Managers = new List<Manager> { manager },  Operations = new List<Operations> { op1 }};

            bank.Show_All_Credit();
        }
    }
}

            

           

            
