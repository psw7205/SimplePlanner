using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimplePlanner.Model
{
    [Serializable]
    public class BoardData
    {
        public BoardData(string _name)
        {
            BoardName = _name;
            Tabs = new List<TabData>();
        }

        public string BoardName { get; set; }
        public List<TabData> Tabs { get; set; }

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

        public void DelTab(BoardForm boardForm)
        {
            boardForm.TabControl.TabPages.Remove(boardForm.TabControl.SelectedTab);
        }

    }
}
