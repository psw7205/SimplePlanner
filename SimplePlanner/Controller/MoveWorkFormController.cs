using SimplePlanner.Model;
using SimplePlanner.View;
using System.Drawing;
using System.Windows.Forms;
namespace SimplePlanner.Controller
{
    public class MoveWorkFormController
    {
        class MyLabel : Label
        {
            public WorkData workData { get; set; }
        }

        //멤버
        public MoveWorkForm moveWorkForm { get; set; }
        BoardForm boardForm;
        public int selectedTabPage { get; set; }
        //생성자
        public MoveWorkFormController(BoardForm boardForm) {
            this.boardForm = boardForm;
            this.moveWorkForm = null;
            this.selectedTabPage = 0;
        }

        public void initTabControl(TabControl t1,TabControl t2) {
            selectedTabPage = boardForm.TabControl.SelectedIndex;
            int size = boardForm.TabControl.TabCount;
            for(int i = 0; i < size; i++)
            {
                TabPage tab = new TabPage(boardForm.TabControl.TabPages[i].Text);
                int count = 0;
                
                foreach (WorkData d in boardForm.CBoardForm.BoardData.Tabs[i].Works)
                {
                    MyLabel l = new MyLabel()
                    {
                        Size = new Size(150, 50),
                        Location = new Point(10, 10 + (count * 70)),
                        Text = d.WorkName,
                        BackColor = d.Color,
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        workData = d
                    };
                    tab.Controls.Add(l);
                    count++;
                }
                tab.UseVisualStyleBackColor = true;
                tab.AllowDrop = true;

                if (i != selectedTabPage)
                {
                    t2.TabPages.Add(tab);
                }
                else {
                    
                    t1.TabPages.Add(tab);
                }
            }
            
           


            
        }
        //폼열기
        public void Apply(TabControl t1, TabControl t2) {
            //모델 쪽을 변경하기
            int size = boardForm.TabControl.TabCount;
            foreach (TabData tab in boardForm.CBoardForm.BoardData.Tabs) {
                tab.Works.Clear();
            }
            foreach (MyLabel w in t1.TabPages[0].Controls)
            {
                boardForm.CBoardForm.BoardData.Tabs[selectedTabPage].Works.Add(w.workData);
            }
            for (int i = 0,j = 0; i < size; i++) {
                if (i == selectedTabPage) continue;
                foreach(MyLabel w in t2.TabPages[j].Controls) {
                    boardForm.CBoardForm.BoardData.Tabs[i].Works.Add(w.workData);
                    
                }  
                j++;
            }
            boardForm.TabControl.TabPages.Clear();
            boardForm.CData.Init(boardForm);

            moveWorkForm.Close();
            moveWorkForm.Dispose();
        }
        public void Cancel() {
            moveWorkForm.Close();
            moveWorkForm.Dispose();
        }
    }

}
