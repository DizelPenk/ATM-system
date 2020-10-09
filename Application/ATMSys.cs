using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
   public static class ATMSys
    {
        private const int minValue = 10000;
        private const int maxValue = 1000000;
        private const int Average = (minValue + maxValue) / 2;
        private static int billOfATM = 12; //Average;
        private static bool isWork = true;

        public static bool CheckStatus ()
        {
            if (billOfATM <= minValue)
            {
                EmploeeBank.AddMessage("В банкомате недостаточно средств");
                MessageBox.Show("Работа банкомата приостановлена, до проведения технических работ!!!!");
                SetNewStatus(false);
                return false;
            }

            if (billOfATM >= maxValue)
            {
                EmploeeBank.AddMessage("Банкомат переполнен");
                MessageBox.Show("Работа банкомата приостановлена !!!!");
                MessageBox.Show("Работа банкомата приостановлена, до проведения технических работ!!!!");
                SetNewStatus(false);
                return false;
            }
            SetNewStatus(true);
            return true;
        }

        public static int CheckStatusForStuff()
        {
            if (billOfATM <= minValue)
            {
                SetNewStatus(false);
                return 1;
            }

            if (billOfATM >= maxValue)
            {
                SetNewStatus(false);
                return 2;
            }
            SetNewStatus(true);
            return 0;
        }
        public static bool GetMoney(int sum)
        {
            if (billOfATM > minValue)
            {
                if (billOfATM - sum > 0)
                {
                    billOfATM -= sum;
                    return true;
                }
                else
                {
                    MessageBox.Show("Просим прощения , но в банкомате слишком мало средств, введите сумму по-меньше или прекратите работу");
                    return false;
                }
            }
            else
                return CheckStatus();
        }

        public static void AddMoney(int sum)
        {
            if (billOfATM + sum <= maxValue)
            {
                billOfATM += sum;
            }
            else
                MessageBox.Show("Просим прощения , но в банкомате слишком много средств, введите сумму по-меньше или прекратите работу");
        }

        public static void IncreaseBalance(int sum)
        {
            billOfATM += sum;
        }

        public static void ReduceBalance(int sum)
        {
            billOfATM -= sum;
        }
        public static void SetNewStatus (bool status)
        {
            isWork = status;
        }

        public static bool  ShowStatus()
        {
            return isWork;
        }
    }
}
