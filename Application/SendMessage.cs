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
    public partial class SendMessage : Form
    {
        int typeOfWork = 0;
        public SendMessage()
        {
            InitializeComponent();
        }

        public SendMessage(int typeOfProblem)
        {
            InitializeComponent();
        }

        private void Sendessage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ATMSys.CheckStatusForStuff() == 1)
            {
                ServicePersonnel.ChangeBillOfBankomat(1);
            }

            else
            {
                MessageBox.Show("Технические работы этого типа не требуются", "От обслуживающего персонала");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ATMSys.CheckStatusForStuff() == 2)
            {
                ServicePersonnel.ChangeBillOfBankomat(2);

            }

            else
            {
                MessageBox.Show("Технические работы этого типа не требуются", "От обслуживающего персонала");
            }
        }
    }
}
