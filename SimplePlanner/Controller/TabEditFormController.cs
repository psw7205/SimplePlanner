using SimplePlanner.View;
using System.Windows.Forms;

namespace SimplePlanner.Controller
{
    /// <summary>
    /// 탭 이름 변경 폼을 컨트롤 하는 클래스
    /// </summary>
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
            if (result.Equals(DialogResult.Cancel))
                return "";

            return tabEditForm.NewTabName;
        }
    }
}
