using DataBase.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Credit:ICredit
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }

        public double Percent { get; set; }

        public string Month { get; set; }

        public decimal Payments { get; set; }

        public Credit(){}

        public Credit(Guid id, decimal amount, double percent, string month, decimal payments)
        {
            Id = id;
            Amount = amount;
            Percent = percent;
            Month = month;
            Payments = payments;
        }

        public void Calculate_Percent()
        {
            Console.WriteLine("Calculate successfully");
        }
    }
}
