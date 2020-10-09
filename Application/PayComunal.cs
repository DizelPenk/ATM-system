using System.Windows.Forms;

namespace Application
{
    public partial class PayComunal : Form
    {
        BankAccount account;
        Label lb;
        public PayComunal()
        {
            InitializeComponent();
        }

        public PayComunal(BankAccount _account, Label _lb)
        {
            InitializeComponent();
            account = _account;
            lb = _lb;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (account.GetMoney(float.Parse(textBox3.Text)))
            {
                MessageBox.Show("Услуга оплачена");
                EmploeeBank.AddMessage($"Произвелась оплата с номера карты {account.numberOfCard} для поставщика " +
                    $"{textBox1.Text} и вида услуги {textBox2.Text}, списанны средства {float.Parse(textBox3.Text)}");
                lb.Text = "Ваш текущий баланс: " + account.cashValue.ToString();
            }
            else
            {
                MessageBox.Show("Недостаточно средств на счету");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void PayComunal_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
