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

        // 데이터가 공백이면 무시
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "" && WorkContent != "")
            {
                CWorkForm.UpdateWorkData();
            }

            this.Close();
        }

        // 삭제 버튼 클릭 시
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "" && WorkContent != "")
            {
                CWorkForm.DeleteWorkData();
            }

            WorkName = "";
            WorkContent = "";
            this.Close();
        }
    }
}
