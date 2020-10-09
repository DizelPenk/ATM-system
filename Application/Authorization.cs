using System.Windows.Forms;

namespace Application
{
    class Authorization
    {
        public static int sizeOfTry = 3;
        public static int numOfCurd = 0;
        public static ClientBank previousClientWhoTryToLogIn;
        public static ClientBank InputInSystem(int inpCurd, string inpPassword)
        {
            var client = User.GetUser(inpCurd);
            if (client !=null)
            {
                if (!client.accessInATM)
                {
                    MessageBox.Show("Ваш счет заблокирован");
                    return null;
                }
                if(previousClientWhoTryToLogIn == null)
                {
                    previousClientWhoTryToLogIn = client;
                }
                if(previousClientWhoTryToLogIn != client)
                {
                    sizeOfTry = 3;
                }
                if (client.password == inpPassword)
                {
                    numOfCurd = inpCurd;
                    return client;
                }
                else
                {
                    --sizeOfTry;
                }
                if(sizeOfTry < 1)
                {
                    client.SetAccess(false);
                    EmploeeBank.AddMessage($"Пользователь {client.FIO} 3 раза ввел неправильный пароль!!! Его счет заблокирован");
                    MessageBox.Show("Ваш счет заблокирован");
                }
                MessageBox.Show("Нерпавильный пароль!!! Введите еще раз");
                return null;
            }
            else
            {
                MessageBox.Show("Нет такого счета!!!");
                return null;
            }
        }

        public static void LogOut()
        {
            sizeOfTry = 3;
            numOfCurd = 0;
        }

    }
}
