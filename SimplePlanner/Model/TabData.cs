using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        // 일정 데이터 추가시 보드 폼에서 일정 라벨 추가
        public void AddWorkLabel(BoardForm boardForm)
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabPage tabPage = boardForm.TabControl.TabPages[tabIndex];

            Label newWork = new Label
            {
                Name = "Work" + Works.Last().MyID,
                Text = Works.Last().WorkName,
                Size = new Size(100, 30),
                Location = new Point(5, 50 + (35 * (Works.Count - 1))),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };

            newWork.Click += (s, e) =>
            {
                boardForm.CBoardForm.LabelClick((Label)s);
            };

            tabPage.Controls.Add(newWork);
        }

        // 프로그램 최초 실행 시 일정 라벨 초기화
        public void InitWorkLabel(BoardForm boardForm, WorkData workData, int i)
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabPage tabPage = boardForm.TabControl.TabPages[tabIndex];

            Label newWork = new Label
            {
                Name = "Work" + workData.MyID,
                Text = workData.WorkName,
                Size = new Size(100, 30),
                Location = new Point(5, 50 + (35 * i)),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };

            newWork.Click += (s, e) =>
            {
                boardForm.CBoardForm.LabelClick((Label)s);
            };

            tabPage.Controls.Add(newWork);
        }
    }
}
