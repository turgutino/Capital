using DataBase.InterFace;
using DataBase.Classes;
using System.Net.WebSockets;


namespace DataBase
{
    public class Bank:IBank
    {
        public string Name { get; set; }

        public double Budget { get; set; }

        public decimal Profit { get; set; }

        public List<Worker> Workers { get; set; }

        public List<Manager> Managers { get; set; }

        public List<Operations> Operations { get; set; }

        public Bank(){}

        public Bank(string name, double budget, decimal profit, List<Worker> workers, List<Manager> managers, List<Operations> operations)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
            Workers = workers;
            Managers = managers;
            Operations = operations;
        }

       
        public void Calculate_Profit()
        {
            Console.WriteLine("Calculate Successfully");
        }

        public void Show_Client_Credit(string fullname)
        {
            Console.WriteLine("Clients : ");
        }

        public void Show_Pay_Credit(string client, decimal money)
        {
            Console.WriteLine("Pays Credits : ");
        }

        public void Show_All_Credit()
        {
            Console.WriteLine("Credits : ");
        }
    }
}
