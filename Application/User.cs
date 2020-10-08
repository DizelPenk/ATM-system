using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class User
    {
    
        public static Dictionary<int, ClientBank> allClients = new Dictionary<int, ClientBank>();
        public static void AddClient (int cod , ClientBank client)
        {
            allClients.Add(cod, client);
        }
        public static void ReadFromFileAllClients ()
        {
            string fileName = "Users.txt";
            StreamReader sr = new StreamReader(fileName);
            List<string> lists = new List<string>();
            while (!sr.EndOfStream)
            {
                lists.Add(sr.ReadLine());
            }
            int curd;
            string fio;
            string pass;
            bool status = true;
            for (int i = 0; i < lists.Count; i++)
            {
                string [] buff = lists[i].Split(';');
                curd = Convert.ToInt32(buff[0]);
                fio = buff[1];
                pass = buff[2];
                status = Convert.ToBoolean(buff[3]);
                AddClient(curd, new ClientBank(curd, fio, pass, status));
            }
        }

        public static ClientBank UserAuthentication(int numCurd, string pass)
        {
           foreach (KeyValuePair<int,ClientBank> keyValue in allClients)
            {
                if (keyValue.Value.numOfCurd == numCurd && keyValue.Value.password == pass)
                    return keyValue.Value;
            }
            return null;
        }
    }
}
