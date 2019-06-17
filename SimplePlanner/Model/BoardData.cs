using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimplePlanner.Model
{
    /// <summary>
    /// 보드 데이터
    /// </summary>
    [Serializable]
    public class BoardData
    {
        public BoardData(string _name = "NewBoard")
        {
            BoardName = _name;
            Tabs = new List<TabData>();
        }
        
        public string BoardName { get; set; }
        public List<TabData> Tabs { get; set; }

        /// <summary>
        /// 탭 데이터 추가 시 보드 폼에도 탭 추가
        /// </summary>
        /// <param name="boardForm"></param>
        /// <param name="name"></param>
        public void AddTab(BoardForm boardForm, string name = "New Tab")
        {
            TabPage tabPage = new TabPage(name)
            {
                UseVisualStyleBackColor = true
            };

            tabPage.Controls.Add(boardForm.CreateWorkBtn);
            boardForm.TabControl.TabPages.Add(tabPage);
            boardForm.TabControl.SelectedTab = boardForm.TabControl.TabPages[boardForm.TabControl.TabCount - 1];
        }

        /// <summary>
        /// 보드 폼에서 탭 삭제
        /// </summary>
        /// <param name="boardForm"></param>
        public void DelTab(BoardForm boardForm)
        {
            int idx = boardForm.TabControl.SelectedIndex - 1;
            boardForm.TabControl.TabPages.Remove(boardForm.TabControl.SelectedTab);

            if (idx < 0)
                idx = 0;

            boardForm.TabControl.SelectTab(idx);
        }
       
        /// <summary>
        /// 탭 이름 변경
        /// </summary>
        /// <param name="boardForm"></param>
        /// <param name="_name"></param>
        public void UpdateTabName(BoardForm boardForm, string _name)
        {
            boardForm.TabControl.SelectedTab.Text = _name;
        }
    }
}
