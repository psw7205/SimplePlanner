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
