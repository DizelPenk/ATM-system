using System;
using System.Windows.Forms;

namespace Application
{
    public partial class AutorizationPanel : Form
    {
        ClientBank client = null;
        public AutorizationPanel()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            client = Authorization.InputInSystem(int.Parse(numberOfCard.Text), password.Text);
            if(client != null)
            {
                Bancomat panel = new Bancomat(client);
                panel.Show();
                this.Visible = false;
            }
        }

        private void numberOfCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AutorizationPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
