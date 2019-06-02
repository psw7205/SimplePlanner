using SimplePlanner.View;
using System.Windows.Forms;

namespace SimplePlanner.Controller
{
    public class TabEditFormController
    {
        readonly TabEditForm tabEditForm;

        public TabEditFormController(TabEditForm _TabEdit)
        {
            tabEditForm = _TabEdit;
        }

        /// <summary>
        /// 탭 폼 열기, 탭 이름 데이터 리턴
        /// </summary>
        /// <returns></returns>
        public string OpenTabEditForm()
        {
            tabEditForm.NewTabName = "";
            DialogResult result = tabEditForm.ShowDialog();
            if (result.Equals(DialogResult.OK))
                return "";

            return tabEditForm.NewTabName;
        }
    }
}
