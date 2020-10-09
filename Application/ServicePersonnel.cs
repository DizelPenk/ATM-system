using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
   public static class ServicePersonnel
    {
        private static int withdrawCash = 500000;
        private static int depositCash = 200000;
        public static void ChangeBillOfBankomat(int typeOfOperation)
        {
            switch (typeOfOperation)
            {
                case 1:
                    {
                        ATMSys.IncreaseBalance(withdrawCash);
                        EmploeeBank.AddMessage("Обслуживающий персонал пополнил банкомат");
                        MessageBox.Show("Обслуживающий персонал пополнил банкомат");
                        break;
                    }
                case 2:
                    {
                        ATMSys.ReduceBalance(depositCash);
                        EmploeeBank.AddMessage("Обслуживающий персонал изъял лишние средства");
                        MessageBox.Show("Обслуживающий персонал пополнил банкомат");
                        break;
                    }
            }
        }
    }
}
