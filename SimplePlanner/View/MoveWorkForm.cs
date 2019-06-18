using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimplePlanner.Controller;
namespace SimplePlanner.View
{
    public partial class MoveWorkForm : Form
    {
        MoveWorkFormController moveWorkFormController;
        Label ClickedLabel;
        TabPage target;
        TabPage nontarget;

        public MoveWorkForm(MoveWorkFormController controller) {//structer
            InitializeComponent();
            moveWorkFormController = controller;
            ClickedLabel = null;
            //tabControl 2개 초기화 시켜야함
            moveWorkFormController.initTabControl(tabControl1,tabControl2);
            foreach (TabPage t in tabControl1.TabPages)
            { 
                foreach (Label label in t.Controls)
                {
                    label.MouseDown += Label_MouseDown;
                }
            }
            foreach (TabPage t in tabControl2.TabPages)
            {
                foreach (Label label in t.Controls)
                {
                    label.MouseDown += Label_MouseDown;
                }
            }
           
        }
      
        public void Link(MoveWorkFormController _moveWorkFormController) {//controller랑 연결
            moveWorkFormController = _moveWorkFormController;
        }
        //event
        private void applyBtn_Click(object sender, EventArgs e)
        {
            //controller불러서 해결
            moveWorkFormController.Apply(tabControl1,tabControl2);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            moveWorkFormController.Cancel();
        }

        private void Label_MouseDown(object sender, MouseEventArgs e) {
            ClickedLabel = sender as Label;
            if (tabControl1.SelectedTab.Contains(ClickedLabel))
            {
                target = tabControl2.SelectedTab;
                nontarget = tabControl1.SelectedTab; 
            }
            else {
                target = tabControl1.SelectedTab;
                nontarget = tabControl2.SelectedTab;
            }
            ClickedLabel.Location = new Point(10, 10+(target.Controls.Count*70));
            target.Controls.Add(ClickedLabel);
            int i = 0;
            foreach (Label label in nontarget.Controls) {
                label.Location = new Point(10,10+(i*70));
                i++;
            }
               
            
            
        }
       
    }
}
