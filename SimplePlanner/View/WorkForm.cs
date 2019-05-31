using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class WorkForm : Form
    {
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

        public void Link(WorkFormController _CWorkForm)
        {
            CWorkForm = _CWorkForm;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "" && WorkContent != "")
            {
                CWorkForm.SendValue();
            }

            this.Close();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "" && WorkContent != "")
            {
                CWorkForm.DeleteWork();
            }
            
            this.Close();
        }
    }
}
