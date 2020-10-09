using System;
using System.Windows.Forms;

namespace Application
{
    public partial class EmploeePanel : Form
    {
        EmploeeBank emploee;
        public EmploeePanel()
        {
            InitializeComponent();
        }
        public EmploeePanel(EmploeeBank emploee)
        {
            InitializeComponent();
            this.emploee = emploee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LookMessages messagePanel = new LookMessages(emploee);
            messagePanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientAccountStatus panel = new ClientAccountStatus();
            panel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnblockClient panel = new UnblockClient();
            panel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAClientPanel panel = new AddAClientPanel();
            panel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ATMSys.CheckStatusForStuff() == 1 || ATMSys.CheckStatusForStuff() == 2)
            {
                SendMessage panel = new SendMessage(ATMSys.CheckStatusForStuff());
                panel.Show();
            }

            else
            {
                MessageBox.Show("Технические работы не требуются","От обслуживающего персонала") ;
            }
        }
    }
}
