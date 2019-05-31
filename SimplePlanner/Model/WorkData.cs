using SimplePlanner.View;
using System;
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

        public void Update(BoardForm boardForm)
        {
            boardForm.CBoardForm.CurrentLabel.Text = this.WorkName;
        }

        public void Delete(BoardForm boardForm)
        {
            Label tmp = boardForm.CBoardForm.CurrentLabel;
            boardForm.TabControl.Controls.Remove(tmp);
            tmp.Dispose();
        }
    }
}
