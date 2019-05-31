using SimplePlanner.Model;
using SimplePlanner.View;

namespace SimplePlanner.Controller
{
    public class WorkFormController
    {
        BoardForm boardForm;
        WorkForm workForm;

        public WorkFormController(BoardForm _boardForm, WorkForm _workForm)
        {
            boardForm = _boardForm;
            workForm = _workForm;
        }

        public void DeleteWork()
        {
            BoardData data = boardForm.CBoardForm.BoardData;
            int tabIdx = boardForm.TabControl.SelectedIndex;
            int workIdx = boardForm.CBoardForm.WorkIndex - 1;

            data.Tabs[tabIdx].Works[workIdx].Delete(boardForm);
            data.Tabs[tabIdx].Works.RemoveAt(workIdx);
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
