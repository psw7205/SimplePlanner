using SimplePlanner.View;

namespace SimplePlanner.Controller
{
    public class TabEditFormController
    {
        readonly BoardForm boardForm;
        readonly TabEditForm tabEditForm;
        public bool flag;

        public TabEditFormController(BoardForm _boardForm, TabEditForm _TabEdit)
        {
            boardForm = _boardForm;
            tabEditForm = _TabEdit;
            flag = true;
        }

        public void UpdateTabName()
        {
            if (flag)
            {
                boardForm.TabControl.SelectedTab.Text = tabEditForm.TabName;
            }
        }

        public string OpenTabEditForm()
        {
            tabEditForm.TabName = "";
            tabEditForm.ShowDialog();
            return tabEditForm.TabName;
        }
    }
}
