using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Operations
    {
        public Guid Id { get; set; }
        public string Process_Name { get; set; }

        public DateTime DateTime { get; set; }

        public Operations(){}

        public Operations(Guid id, string process_Name, DateTime dateTime)
        {
            Id = id;
            Process_Name = process_Name;
            DateTime = dateTime;
        }

        
    }
}
