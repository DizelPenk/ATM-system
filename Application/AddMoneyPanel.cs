using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class AddMoneyPanel : Form
    {
        BankAccount account;
        Label lb;
        public AddMoneyPanel()
        {
            InitializeComponent();
        }

        public AddMoneyPanel(BankAccount _account, Label _lb)
        {
            InitializeComponent();
            account = _account;
            lb = _lb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.AddMoney((int)numericUpDown1.Value);
            MessageBox.Show("Наличные успешно внесены");
            EmploeeBank.AddMessage($"Внесены наличные на счет : {account.numberOfCard} в размере {(int)numericUpDown1.Value}");
            lb.Text = "Ваш текущий баланс: " + account.cashValue.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddMoneyPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
