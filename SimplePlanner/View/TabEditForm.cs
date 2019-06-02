using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class TabEditForm : Form
    {
        public string NewTabName
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TabEditForm()
        {
            InitializeComponent();
        }


        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
