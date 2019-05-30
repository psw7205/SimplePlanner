using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        class NewWorkForm : Form
        {
            Label workName;
            Label workContent;
            TextBox workNameInput;
            public TextBox workContentInput;
            Button okButton;
            Button cancel;
            public Board board;
            public int tabIndex;
            /////////////////////
            private bool flag;
            public bool Flag { get; set; }
            public Work w;
            /////////////////////
            public NewWorkForm()
            {
                this.Text = "새로운 일정";
                /////////////////////
                flag = false;
                //Flag = false;
                /////////////////////

                this.workName = new Label();
                this.workName.Text = "일정 이름";
                this.workName.Name = "workNameLable";
                this.workName.Size = new System.Drawing.Size(80, 20);
                this.workName.Location = new System.Drawing.Point(5, 5);

                this.workNameInput = new TextBox();
                this.workNameInput.Name = "workNameInputTextBox";
                this.workNameInput.Size = new System.Drawing.Size(200, 20);
                this.workNameInput.Location = new System.Drawing.Point(5, 30);
                this.workNameInput.Multiline = true;

                this.workContent = new Label();
                this.workContent.Text = "일정 내용";
                this.workContent.Name = "workContent";
                this.workContent.Size = new System.Drawing.Size(80, 20);
                this.workContent.Location = new System.Drawing.Point(5, 75);

                this.workContentInput = new TextBox();
                this.workContentInput.Name = "workContentInputTextBox";
                this.workContentInput.Size = new System.Drawing.Size(200, 100);
                this.workContentInput.Location = new System.Drawing.Point(5, 105);
                this.workContentInput.Multiline = true;

                this.okButton = new Button();
                this.okButton.Text = "OK";
                this.okButton.Name = "okButton";
                this.okButton.Size = new System.Drawing.Size(100, 30);
                this.okButton.Location = new System.Drawing.Point(60, 220);
                this.okButton.Click += OkButton_Click;

                this.cancel = new Button();
                this.cancel.Text = "cancel";
                this.cancel.Name = "cancelButton";
                this.cancel.Size = new System.Drawing.Size(100, 30);
                this.cancel.Location = new System.Drawing.Point(165, 220);
                this.cancel.Click += cancelButton_Click;

                this.Controls.Add(this.workName);
                this.Controls.Add(this.workNameInput);
                this.Controls.Add(this.workContent);
                this.Controls.Add(this.workContentInput);
                this.Controls.Add(this.okButton);
                this.Controls.Add(this.cancel);

            }

            private void OkButton_Click(object sender, EventArgs e)
            {
                //board.tabs[tabIndex].CreateNewWork(workNameInput.Text,workContentInput.Text,tabIndex, board.Form);

                //////////////////////////////////////
                //board.tabs.ElementAt(tabIndex).CreateNewWork(workNameInput.Text, workContentInput.Text, tabIndex, board.Form);

                if (Flag)
                {
                    w.Text = workNameInput.Text;
                    w.Content = workContentInput.Text;
                }
                else
                {
                    board.Form.CreateNewWork(workNameInput.Text, workContentInput.Text, tabIndex);
                }
                //////////////////////////////////////

                this.Close();
            }

            private void cancelButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            public void SetText(Work w)
            {
                workNameInput.Text = w.Text;
                workContentInput.Text = w.Content;
            }
        }

        /*
        internal void CreateNewTabpage(Tab newTab)
        {
            throw new NotImplementedException();
        }
        */

        //Form1 Class
        // 멤버
        Board board;
        Button MakeNewWorkButton;

        /////////////////////////////////////////
        Button editWorkName;
        /////////////////////////////////////////

        //생성자
        public Form1()
        {
            InitializeComponent();
            MakeNewWorkButton = new Button();
            MakeNewWorkButton.Size = new Size(100, 30);
            MakeNewWorkButton.Location = new Point(10, 10);
            MakeNewWorkButton.Text = "새 일정";
            MakeNewWorkButton.Name = "MakeNewWorkButton";
            MakeNewWorkButton.Click += new EventHandler(MakeNewWork_Click);

            //////////////////////////////////////////
            editWorkName = new Button();

            if (this.board != null) return;
            this.board = new Board();
            this.board.Form = this;
            label1.Text = board.Name;


            BindingClass bindingClass = new BindingClass();
            DataSave dataSave = new DataSave();
            bindingClass = dataSave.DeserializeData();
            if(bindingClass != null)
            {
                board.Name = bindingClass.BoardName;
                foreach (var bindingTab in bindingClass.Tabs)
                {
                    CreateNewTabpage(bindingTab.TabName);
                    int idx = board.tabs.Count - 1;
                    foreach (var bindingWork in bindingTab.Works)
                    {
                        board.Form.CreateNewWork(bindingWork.WorkName, bindingWork.WorkContent, idx);
                    }
                }
            }
            else
            {
                CreateNewTabpage("To do");
                CreateNewTabpage("Doing");
                CreateNewTabpage("Done");
            }

            MakeNewWorkButton.TabIndex = 0;
            this.tabControl1.TabPages[0].Controls.Add(MakeNewWorkButton);
        }

        //Method and EventMethod
        private void MakeNewBoardbutton_Click(object sender, EventArgs e)
        {

        }

        private void newTab_Click(object sender, EventArgs e)
        {
            //this.board.CreateNewTab();
            CreateNewTabpage("newTab");
        }

        private void MakeNewWork_Click(object sender, EventArgs e)
        {
            NewWorkForm newWorkForm = new NewWorkForm();
             Button button = (Button)sender;
            newWorkForm.tabIndex = button.TabIndex;
            newWorkForm.board = board;
            newWorkForm.ShowDialog();
        }

        public void CreateNewTabpage(/*Tab newTab*/ String name)
        {
            Tab newTab = new Tab(name);
            board.tabs.Add(newTab);
            newTab.UseVisualStyleBackColor = true;
            tabControl1.TabPages.Add(newTab);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e) // 일정 생성 버튼을 선택된 Tabpage으로 이동시키는 이벤트 함수
        {
            e.TabPage.Controls.Add(MakeNewWorkButton);
            MakeNewWorkButton.TabIndex = e.TabPageIndex;
        }

        private void editTap_Click(object sender, EventArgs e)
        {
            EditTapForm editTapForm = new EditTapForm(tabControl1.SelectedTab);
            editTapForm.ShowDialog();

        }

        public void ShowNewWorkOnTabPage(int tabPageIndex, string name, int count)
        {
            // 일단은 생성이 되는 모습만. 삭제가 이루어지면 
            // 기존의 Label들도 위치변화가 있어야하지만
            // 일단은 추가만 구현한다.           
            TabPage tabPage = this.tabControl1.TabPages[tabPageIndex];

        }

        public void CreateNewWork(string name, string content, int tabIndex)
        {
            TabPage tabPage = this.tabControl1.TabPages[tabIndex];

            Tab selectedTab = board.tabs.ElementAt(tabIndex);
            List<Work> w = selectedTab.works;

            Work newWork = new Work(name, content);
            newWork.Size = new Size(100, 30);
            newWork.Location = new Point(5, 50 + (35 * w.Count));
            newWork.BorderStyle = BorderStyle.FixedSingle;
            newWork.TextAlign = ContentAlignment.MiddleCenter;
            newWork.Click += NewLabel_Click;
            selectedTab.Controls.Add(newWork);

            selectedTab.works.Add(newWork);
            tabPage.Controls.Add(newWork);
        }

        private void NewLabel_Click(object sender, EventArgs e)
        {
            NewWorkForm newWorkForm = new NewWorkForm();
            Work work = (Work)sender;
            newWorkForm.w = work;
            newWorkForm.Flag = true;
            newWorkForm.SetText(work);
            newWorkForm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindingClass bindingClass = new BindingClass();
            bindingClass.BoardName = this.board.Name;
            bindingClass.Tabs = new List<BindingTab>();

            foreach (var tab in this.board.tabs)
            {
                BindingTab bindingTab = new BindingTab();
                bindingTab.TabName = tab.Text;
                bindingTab.Works = new List<BindingWork>();

                foreach (var work in tab.works)
                {
                    bindingTab.Works.Add(new BindingWork(work.Text, work.Content));
                }
                bindingClass.Tabs.Add(bindingTab);
            }

            DataSave dataSave = new DataSave();
            dataSave.SerializeData(bindingClass);
        }
    }

    class EditTapForm : Form
    {
        Label lblNewName;
        TextBox txtNewName;
        Button btnApply, btnClose;
        TabPage tab;

        public EditTapForm(TabPage tab)
        {
            this.Width = 265;
            this.Height = 160;

            this.tab = tab;

            lblNewName = new Label();
            lblNewName.Text = "새 이름";

            lblNewName.Size = new Size(50, 40);
            lblNewName.Location = new Point(20, 20);

            txtNewName = new TextBox();
            txtNewName.Text = tab.Text;
            txtNewName.Size = new Size(148, 40);
            txtNewName.Location = new Point(80, 15);

            btnApply = new Button();
            btnApply.Text = "apply";
            btnApply.Size = new Size(100, 30);
            btnApply.Location = new Point(20, 80);
            btnApply.Click += BtnApply_Click;

            btnClose = new Button();
            btnClose.Text = "close";
            btnClose.Size = new Size(100, 30);
            btnClose.Location = new Point(130, 80);
            btnClose.Click += BtnClose_Click;

            Controls.Add(lblNewName);
            Controls.Add(txtNewName);
            Controls.Add(btnApply);
            Controls.Add(btnClose);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            tab.Text = txtNewName.Text;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    ////////////////////////////////////////////////////////////////
}
