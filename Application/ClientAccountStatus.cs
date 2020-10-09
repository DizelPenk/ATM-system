using System.Windows.Forms;

namespace Application
{
    public partial class ClientAccountStatus : Form
    {
        public ClientAccountStatus()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            foreach (var item in User.allClients)
            {
                dataGridView1.Rows.Add(item.Value.FIO, item.Value.password, item.Value.numOfCurd, !item.Value.accessInATM);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
