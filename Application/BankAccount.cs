using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class BankAccount
    {
        public int numberOfCard = 0;
        public float cashValue = 0;

        public BankAccount(int numberOfCard, float cashValue)
        {
            this.numberOfCard = numberOfCard;
            this.cashValue = cashValue;
        }

        public bool GetMoney(float sum)
        {
            if(cashValue - sum >= 0)
            {
                cashValue -= sum;
                return true;
            }
            return false;
        }

        public void AddMoney(int sum)
        {
            cashValue += sum;
        }
    }
}
