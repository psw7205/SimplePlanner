using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePlanner.Model
{
    [Serializable]
    public class TabData
    {
        public TabData(string _name)
        {
            TabName = _name;
            Works = new List<WorkData>();
        }

        public string TabName { get; set; }
        public List<WorkData> Works { get; set; }

        public void WorkUpdate(BoardForm boardForm)
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabPage tabPage = boardForm.TabControl.TabPages[tabIndex];

            Label newWork = new Label();
            newWork.Text = Works.Last().WorkName;
            string Content = Works.Last().WorkContent;
            newWork.Size = new Size(100, 30);
            newWork.Location = new Point(5, 50 + (35 * (Works.Count -1)));
            newWork.BorderStyle = BorderStyle.FixedSingle;
            newWork.TextAlign = ContentAlignment.MiddleCenter;

            newWork.Click += (s, e) => {
                Label tmp = (Label)s;
                boardForm.CBoardForm.IsClicked = true;
                boardForm.CBoardForm.CurrentWork.WorkName = tmp.Text;
                boardForm.CBoardForm.CurrentWork.WorkContent = Content;
                boardForm.CBoardForm.OpenWorkForm();
            };

            tabPage.Controls.Add(newWork);
        }
    }
}
