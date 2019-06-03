using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class WorkForm : Form
    {
        WorkFormController CWorkForm;
        public bool flag;

        /// <summary>
        /// 일정 이름
        /// </summary>
        public string WorkName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }

        public DateTime date
        {
            get { return dateTime.Value; }
            set { dateTime.Value = value; }
        }

        /// <summary>
        /// 일정 내용
        /// </summary>
        public string WorkContent
        {
            get { return contentTextBox.Text; }
            set { contentTextBox.Text = value; }
        }

        public WorkForm()
        {
            InitializeComponent();
            flag = false;
        }

        public void Link(WorkFormController _CWorkForm)
        {
            CWorkForm = _CWorkForm;
        }

        /// <summary>
        /// 컨트롤러의 OKBtnClicked함수 호출
        /// 폼 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "")
            {
                CWorkForm.OKBtnClicked();
            }

            this.Close();
        }

        /// <summary>
        /// 컨트롤러의 DeleteWorkData()함수 호출
        /// 내용 초기화 후 폼 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "")
            {
                CWorkForm.DeleteWorkData();
            }

            WorkName = "";
            WorkContent = "";
            dateTime.ResetText();
            this.Close();
        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                colorLabel.BackColor = colorDialog.Color;
            }
        }
    }
}
