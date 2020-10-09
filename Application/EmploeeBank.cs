using System.Collections.Generic;

namespace Application
{
    public class EmploeeBank : MainUser
    {
        public static List<string> allMessages = new List<string>();
        public int codeOfEmploee;
        public EmploeeBank(int code,string fio, string pass , bool status = true) :base (fio, pass, status)
        {
            codeOfEmploee = code;
        }

        public static void AddMessage(string _message)
        {
            allMessages.Add(_message);
        }

        public static void ClearAllMessage()
        {
            allMessages.Clear();
        }
    }
}
