using SimplePlanner.Controller;
using System;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class WorkForm : Form
    {
        WorkFormController CWorkForm;

        /// <summary>
        /// 일정 이름
        /// </summary>
        public string WorkName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        /// <summary>
        /// 일정 내용
        /// </summary>
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

        /// <summary>
        /// 컨트롤러의 OKBtnClicked함수 호출
        /// 폼 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (WorkName != "" && WorkContent != "")
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
