using System;
using System.Windows.Forms;

namespace Application
{
    public partial class UnblockClient : Form
    {
        public UnblockClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = User.GetUser(int.Parse(textBox1.Text));
            if(client != null)
            {
                client.SetAccess(true);
                MessageBox.Show("Доступ востановлен");
            }
            else
            {
                MessageBox.Show("Нет такого пользователя");
            }
        }

        private void UnblockClient_Load(object sender, EventArgs e)
        {

        }
    }
}
