using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class TabEditForm : Form
    {
        TabEditFormController CTabEditForm;
        public string TabName
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TabEditForm()
        {
            InitializeComponent();
        }

        public void Link(TabEditFormController _CTabEditForm)
        {
            CTabEditForm = _CTabEditForm;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CTabEditForm.UpdateTabName();

            this.Close();
        }
    }
}
