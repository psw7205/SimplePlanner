using SimplePlanner.View;

namespace SimplePlanner.Controller
{
    public class TabEditFormController
    {
        readonly BoardForm boardForm;
        readonly TabEditForm tabEditForm;

        public TabEditFormController(BoardForm _boardForm, TabEditForm _TabEdit)
        {
            boardForm = _boardForm;
            tabEditForm = _TabEdit;
        }

        /// <summary>
        /// 탭 폼 열기, 탭 이름 데이터 리턴
        /// </summary>
        /// <returns></returns>
        public string OpenTabEditForm()
        {
            tabEditForm.NewTabName = "";
            tabEditForm.ShowDialog();
            return tabEditForm.NewTabName;
        }
    }
}
