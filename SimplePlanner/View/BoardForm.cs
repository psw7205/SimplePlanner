using SimplePlanner.Controller;
using SimplePlanner.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class BoardForm : Form
    {
        readonly WorkForm workForm;
        readonly TabEditForm tabEditForm;

        public BoardFormController CBoardForm;
        public WorkFormController CWorkForm;
        public TabEditFormController CTabForm;
        public DataController CData;

        public Button CreateWorkBtn { get; }

        public TabControl TabControl
        {
            get { return tabControl; }
            set { tabControl = value; }
        }

        public BoardForm()
        {
            InitializeComponent();

            workForm = new WorkForm();
            tabEditForm = new TabEditForm();

            CreateWorkBtn = new Button
            {
                Size = new Size(100, 30),
                Location = new Point(10, 10),
                Text = "새 일정",
                Name = "MakeNewWorkButton"
            };

            CreateWorkBtn.Click += (s, e) =>
            {
                CBoardForm.IsClicked = false;
                CBoardForm.OpenWorkForm();
            };


            CBoardForm = new BoardFormController(this, workForm);
            CWorkForm = new WorkFormController(this, workForm);
            CTabForm = new TabEditFormController(this, tabEditForm);

            workForm.Link(CWorkForm);
            tabEditForm.Link(CTabForm);

            CData = new DataController();
            BoardData tmp = CData.DeserializeData();
            if (tmp != null)
            {
                CBoardForm.BoardData = tmp;
                CData.Init(this);
            }
            else
            {
                CBoardForm.Init();
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CTabForm.flag = false;
            string name = CTabForm.OpenTabEditForm();
            CBoardForm.AddTabData(name);
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            CBoardForm.MoveBtn();
        }

        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CData.SerializeData(CBoardForm.BoardData);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CTabForm.flag = true;
            CTabForm.OpenTabEditForm();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            CBoardForm.DelTabData();
        }
    }
}
