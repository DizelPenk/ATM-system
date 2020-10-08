using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class EmploeeBank : MainUser
    {
        public int codeOfEmploee;
        public EmploeeBank(int code,string fio, string pass , bool status = true) :base (fio, pass, status)
        {
            codeOfEmploee = code;
        }
       
    }
}
