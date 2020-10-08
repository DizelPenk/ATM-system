using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
     public class ClientBank : MainUser
    {
        public int numOfCurd;
        public ClientBank(int curd,string fio, string pass, bool status = true) :base( fio,  pass, status)
        {
            numOfCurd = curd;
        }

    }
}
