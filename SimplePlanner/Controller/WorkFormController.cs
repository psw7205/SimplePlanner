using SimplePlanner.Model;
using SimplePlanner.View;

namespace SimplePlanner.Controller
{
    public class WorkFormController
    {
        readonly BoardForm boardForm;
        readonly WorkForm workForm;

        public WorkFormController(BoardForm _boardForm, WorkForm _workForm)
        {
            boardForm = _boardForm;
            workForm = _workForm;
        }

        public void DeleteWork()
        {
            BoardData data = boardForm.CBoardForm.BoardData;
            int tabIdx = boardForm.TabControl.SelectedIndex;

            WorkData.Delete(boardForm);

            WorkData tmp = null;
            foreach (var item in data.Tabs[tabIdx].Works)
            {
                if (item.MyIndex == boardForm.CBoardForm.WorkIndex)
                {
                    tmp = item;
                    break;
                }
            }

            data.Tabs[tabIdx].Works.Remove(tmp);

            WorkData.Update(boardForm);
        }

        public void SendValue()
        {
            boardForm.CBoardForm.CurrentWork.WorkName = workForm.WorkName;
            boardForm.CBoardForm.CurrentWork.WorkContent = workForm.WorkContent;

            if (!boardForm.CBoardForm.IsClicked)
            {
                boardForm.CBoardForm.CreateWork();
            }
            else
            {
                boardForm.CBoardForm.UpdateWork();
            }

            boardForm.CBoardForm.CurrentWork.WorkName = workForm.WorkName = "";
            boardForm.CBoardForm.CurrentWork.WorkContent = workForm.WorkContent = "";
        }

    }
}
