using SimplePlanner.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePlanner.Model
{
    [Serializable]
    public class WorkData
    {
        public static int ID;
        public int MyID;
        public bool IsClicked;

        public WorkData(string _name = "", string _content = "")
        {
            WorkName = _name;
            WorkContent = _content;
            MyID = ID;
            ID++;
            IsClicked = false;
        }

        public string WorkName { get; set; }
        public string WorkContent { get; set; }
        
        // 일정 라벨의 텍스트 변경
        public void UpdateLabelText(BoardForm boardForm)
        {
            Label label = boardForm.CBoardForm.CurrentLabel;
            label.Text = this.WorkName;
        }

        // 일정 삭제 시 기존 일정의 위치 업데이트
        public static void UpdateLabelLocation(BoardForm boardForm)
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

        // 일정라벨 삭제
        public static void DeleteLabel(BoardForm boardForm)
        {
            Label tmp = boardForm.CBoardForm.CurrentLabel;
            boardForm.TabControl.Controls.Remove(tmp);
            tmp.Dispose();
        }
    }
}
