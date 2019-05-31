using SimplePlanner.Controller;
using SimplePlanner.Model;
using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class BoardForm : Form
    {
        WorkForm workForm;

        public BoardFormController CBoardForm;
        public WorkFormController CWorkForm;
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

            CreateWorkBtn = new Button();
            CreateWorkBtn.Size = new Size(100, 30);
            CreateWorkBtn.Location = new Point(10, 10);
            CreateWorkBtn.Text = "새 일정";
            CreateWorkBtn.Name = "MakeNewWorkButton";
            CreateWorkBtn.Click += (s, e) => {
                CBoardForm.IsClicked = false;
                CBoardForm.OpenWorkForm();
            };

            CBoardForm = new BoardFormController(this, workForm);
            CWorkForm = new WorkFormController(this, workForm);

            workForm.Link(CBoardForm, CWorkForm);

            CData = new DataController();
            BoardData tmp = CData.DeserializeData();
            if (tmp != null)
            {
                CBoardForm.BoardData = tmp;
            }

            CData.init(this);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CBoardForm.AddTab();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            CBoardForm.MoveCreateWorkBtn();
        }

        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CData.SerializeData(CBoardForm.BoardData);
        }
    }
}
