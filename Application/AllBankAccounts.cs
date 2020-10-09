using System;
using System.Collections.Generic;
using System.IO;

namespace Application
{
    public static class AllBankAccounts
    { 
            public static Dictionary<int, BankAccount> allBankAccounts = new Dictionary<int, BankAccount>();
            public static void AddBankAccount(int cod, BankAccount bank)
            {
                allBankAccounts.Add(cod, bank);
            }

            public static void ReadFromFileAllClients()
            {
                string fileName = "BankAccounts.txt";
                try
                {
                    StreamReader sr = new StreamReader(fileName);
                    List<string> lists = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        lists.Add(sr.ReadLine());
                    }
                    int curd;
                    float cash;
                    for (int i = 0; i < lists.Count; i++)
                    {
                        string[] buff = lists[i].Split(';');
                        curd = Convert.ToInt32(buff[0]);
                        cash = float.Parse(buff[1]);
                        AddBankAccount(curd, new BankAccount(curd, cash));
                    }
                    sr.Close();
                }
                catch
                {
                    var temp = new BankAccount(11111, 156.25f);
                    AddBankAccount(temp.numberOfCard, temp);
                    temp = new BankAccount(22222, 10000f);
                    AddBankAccount(temp.numberOfCard, temp);
                    WriteToFileAllClients();
                }
            }

            public static void WriteToFileAllClients()
            {
                string fileName = "BankAccounts.txt";
                StreamWriter sr = new StreamWriter(fileName);
                foreach (var item in allBankAccounts)
                {
                    sr.WriteLine(item.Value.numberOfCard + ";" + item.Value.cashValue);
                }
                sr.Close();
            }

            public static BankAccount GetAccount(int numCurd)
            {
                if (allBankAccounts.ContainsKey(numCurd))
                {
                    return allBankAccounts[numCurd];
                }
                return null;
            }
        }
    }