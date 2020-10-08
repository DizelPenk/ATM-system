namespace Application
{
    public class MainUser
    {
        public string FIO;
        public string password;
        public bool accessInATM = true;

        public MainUser(string fio, string pass, bool status = true)
        {
            FIO = fio;
            password = pass;
            accessInATM = status;
        }
        public void SetAccess(bool typeAccess)
        {
            accessInATM = typeAccess;
        }
    }
}