using System.Windows.Forms;

namespace Application
{
    public partial class LookMessages : Form
    {
        public EmploeeBank emploee;
        public LookMessages()
        {
            InitializeComponent();
        }
        public LookMessages(EmploeeBank emploee)
        {
            InitializeComponent();
            this.emploee = emploee;
            foreach (var item in EmploeeBank.allMessages)
            {
                richTextBox1.AppendText(item + "\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
