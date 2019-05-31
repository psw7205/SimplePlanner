using SimplePlanner.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            boardForm.CBoardForm.CreateWork();

            workForm.WorkName = "";
            workForm.WorkContent = "";
        }

        public void LoadValue()
        {
            workForm.WorkName = boardForm.CBoardForm.CurrentWork.WorkName;
            workForm.WorkContent = boardForm.CBoardForm.CurrentWork.WorkContent;
        }
    }
}
