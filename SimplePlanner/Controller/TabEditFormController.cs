using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePlanner.Controller
{
    public class TabEditFormController
    {
        BoardForm boardForm;
        TabEditForm tabEditForm;

        public TabEditFormController(BoardForm _boardForm, TabEditForm _TabEdit)
        {
            boardForm = _boardForm;
            tabEditForm = _TabEdit;
        }

        public void UpdateTabName()
        {
            boardForm.TabControl.SelectedTab.Text = tabEditForm.TabName;
            tabEditForm.TabName = "";
        }

        public void OpenTabEditForm()
        {
            tabEditForm.ShowDialog();
        }
    }
}
