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
    public partial class MainForm : Form
    {
        EmploeeBank emploee = new EmploeeBank(55555, "Ktoto", "password");
        public MainForm()
        {
            InitializeComponent();
            User.ReadFromFileAllClients();
            AllBankAccounts.ReadFromFileAllClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmploeePanel panel = new EmploeePanel(emploee);
            panel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutorizationPanel panel = new AutorizationPanel();
            panel.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
