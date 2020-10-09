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
    public partial class AddAClientPanel : Form
    {
        public AddAClientPanel()
        {
            InitializeComponent();
        }

        private void AddAClientPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newCurd = int.Parse(inputNumOfClientTextBox.Text);
            string newFIO = inputFIOOfClientTextBox.Text;
            string newPass = inputPassOfClientTextBox.Text;
            bool newStatus = true;
            int newBill = int.Parse(inputBillOfClientTextBox.Text);
            ClientBank newClient = new ClientBank(newCurd, newFIO, newPass,newStatus);
            BankAccount newBankAccount = new BankAccount(int.Parse(inputNumOfClientTextBox.Text), newBill);
            User.AddClient(newCurd, newClient);
            User.WriteToFileAllClients();
            AllBankAccounts.AddBankAccount(newCurd,newBankAccount);
            AllBankAccounts.WriteToFileAllClients();
            inputNumOfClientTextBox.Clear();
            inputFIOOfClientTextBox.Clear();
            inputPassOfClientTextBox.Clear();
            inputBillOfClientTextBox.Clear();
        }

    }
}
