using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Authorization
    {
        int sizeOfTry = 3;
        int numOfCurd = 0;
        List<Bank_Bill> allBills;
        public void InputInSystem(int inpCurd, string inpPassword)
        {
            if (User.UserAuthentication(inpCurd,inpPassword)!=null)
            {
                numOfCurd = inpCurd;
            }
        }

    }
}
