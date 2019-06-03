using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class TabEditForm : Form
    {
        public string NewTabName
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public TabEditForm()
        {
            InitializeComponent();
        }


        private void OKBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
