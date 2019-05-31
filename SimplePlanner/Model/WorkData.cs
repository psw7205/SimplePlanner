using SimplePlanner.View;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimplePlanner.Model
{
    [Serializable]
    public class WorkData
    {
        public static int Index;
        public int MyIndex;
        public bool IsClicked;

        public WorkData(string _name = "", string _content = "")
        {
            WorkName = _name;
            WorkContent = _content;
            MyIndex = Index;
            Index++;
            IsClicked = false;
        }

        public string WorkName { get; set; }
        public string WorkContent { get; set; }

        public void LabelTextUpdate(BoardForm boardForm)
        {
            Label label = boardForm.CBoardForm.CurrentLabel;
            label.Text = this.WorkName;
        }

        public static void Update(BoardForm boardForm)
        {
            TabPage tab = boardForm.TabControl.SelectedTab;

            int i = 0;
            foreach (var item in tab.Controls)
            {
                if (item is Label tmp)
                {
                    tmp.Location = new Point(5, 50 + (35 * i));
                    i++;
                }
            }
        }

        public static void Delete(BoardForm boardForm)
        {
            Label tmp = boardForm.CBoardForm.CurrentLabel;
            boardForm.TabControl.Controls.Remove(tmp);
            tmp.Dispose();
        }
    }
}
