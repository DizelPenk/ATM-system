using System;
using System.Windows.Forms;

namespace Application
{
    public partial class GetMoneyPanel : Form
    {
        BankAccount account;
        Label lb;
        public GetMoneyPanel()
        {
            InitializeComponent();
        }
        public GetMoneyPanel(BankAccount _account, Label _lb)
        {
            InitializeComponent();
            account = _account;
            lb = _lb;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (account.GetMoney((float)numericUpDown1.Value))
                {
                    MessageBox.Show("Наличные успешно сняты");
                    EmploeeBank.AddMessage($"Сняты наличные средства со счета: {account.numberOfCard}");
                    lb.Text = "Ваш текущий баланс: " + account.cashValue.ToString();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на счету");
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
