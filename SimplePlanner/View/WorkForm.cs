using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class WorkForm : Form
    {
        BoardFormController CBoardForm;
        WorkFormController CWorkForm;

        public string WorkName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        public string WorkContent
        {
            get { return ContentTextBox.Text; }
            set { ContentTextBox.Text = value; }
        }

        public WorkForm()
        {
            InitializeComponent();
        }

        public void Link(BoardFormController _CBoardForm, WorkFormController _CWorkForm)
        {
            CBoardForm = _CBoardForm;
            CWorkForm = _CWorkForm;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            CWorkForm.SendValue();
            this.Close();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            CWorkForm.DeleteWork();
            this.Close();
        }
    }
}
