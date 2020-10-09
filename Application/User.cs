using System;
using System.Collections.Generic;
using System.IO;

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
            try
            {
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
                sr.Close();
            }
            catch
            {
                var temp = new ClientBank(11111, "Грушев Вениамин Абрикосович", "123456");
                AddClient(temp.numOfCurd, temp);
                temp = new ClientBank(22222, "Петров Петр Иванович", "123456789");
                AddClient(temp.numOfCurd, temp);
                WriteToFileAllClients();
            }
        }
        
        public static void WriteToFileAllClients()
        {
            string fileName = "Users.txt";
            StreamWriter sr = new StreamWriter(fileName);
            foreach (var item in allClients)
            {
                sr.WriteLine(item.Value.numOfCurd + ";" + item.Value.FIO + ";" + item.Value.password + ";" +
                    item.Value.accessInATM.ToString());
            }
            sr.Close();
        }

        public static ClientBank GetUser(int numCurd)
        {
            if (allClients.ContainsKey(numCurd))
            {
                return allClients[numCurd];
            }
            return null;
        }
    }
}
