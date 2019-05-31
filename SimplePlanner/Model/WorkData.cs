using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void UpdateWork(BoardForm boardForm)
        {
            boardForm.CBoardForm.CurrentLabel.Text = this.WorkName;
        }

    }
}
