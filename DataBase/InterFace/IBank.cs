using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.InterFace
{
    public interface IBank
    {
        void Calculate_Profit();
        void Show_Client_Credit(string fullname);
        void Show_Pay_Credit(string client,decimal money);
        void Show_All_Credit();

    }
}
