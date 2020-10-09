using System.Windows.Forms;

namespace Application
{
    public partial class Bancomat : Form
    {
        ClientBank client;
        BankAccount account;
        public Bancomat()
        {
            InitializeComponent();
        }
        public Bancomat(ClientBank _client)
        {
            InitializeComponent();
            client = _client;
            account = AllBankAccounts.GetAccount(client.numOfCurd);
            label1.Text = "Ваш текущий баланс: " + account.cashValue.ToString();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (ATMSys.CheckStatus() != false)
            {
                GetMoneyPanel panel = new GetMoneyPanel(account, label1);
                panel.Show();
            }
            else
            {
                MessageBox.Show("Дождитесь обслуживающего персонала или пректатите работу");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (ATMSys.CheckStatus() != false)
            {
                AddMoneyPanel panel = new AddMoneyPanel(account, label1);
                panel.Show();
            }
            else
            {
                MessageBox.Show("Дождитесь обслуживающего персонала или пректатите работу");
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (ATMSys.CheckStatus() != false)
            {
                PayComunal panel = new PayComunal(account, label1);
                panel.Show();
            }
            else
            {
                MessageBox.Show("Дождитесь обслуживающего персонала или пректатите работу");
            }
        }

        private void Bancomat_Load(object sender, System.EventArgs e)
        {

        }
    }
}
