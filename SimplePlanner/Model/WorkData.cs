using SimplePlanner.View;
using System;

namespace SimplePlanner.Model
{
    [Serializable]
    public class WorkData
    {
        public static int Index;
        public int MyIndex;

        public WorkData(string _name = "", string _content = "")
        {
            WorkName = _name;
            WorkContent = _content;
            MyIndex = Index;
            Index++;
        }

        public string WorkName { get; set; }
        public string WorkContent { get; set; }

        public void Update(BoardForm boardForm)
        {
            boardForm.CBoardForm.CurrentLabel.Text = this.WorkName;
        }

    }
}
