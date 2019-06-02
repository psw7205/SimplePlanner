using SimplePlanner.Model;
using SimplePlanner.View;

namespace SimplePlanner.Controller
{
    public class WorkFormController
    {
        readonly BoardForm boardForm;
        readonly WorkForm workForm;

        /// <summary>
        /// 컨트롤러 생성시 폼 연결
        /// </summary>
        /// <param name="_boardForm"></param>
        /// <param name="_workForm"></param>
        public WorkFormController(BoardForm _boardForm, WorkForm _workForm)
        {
            boardForm = _boardForm;
            workForm = _workForm;
        }

        /// <summary>
        /// 일정 삭제
        /// 보드 폼에서 현재 클릭한 일정데이터, 라벨 삭제
        /// </summary>
        public void DeleteWorkData()
        {
            BoardData data = boardForm.CBoardForm.BoardData;
            int tabIdx = boardForm.TabControl.SelectedIndex;

            WorkData.DeleteLabel(boardForm);

            WorkData tmp = null;
            foreach (var item in data.Tabs[tabIdx].Works)
            {
                if (item.MyID == boardForm.CBoardForm.CurrentWorkIndex)
                {
                    tmp = item;
                    break;
                }
            }

            data.Tabs[tabIdx].Works.Remove(tmp);
            WorkData.UpdateLabelLocation(boardForm);
        }

        /// <summary>
        /// 일정 폼 호출 시
        /// 기존 일정 라벨을 클릭했으면 일정 업데이트
        /// 새 일정을 클릭했다면 새 일정 추가
        /// </summary>
        public void OKBtnClicked()
        {
            boardForm.CBoardForm.CurrentWork.WorkName = workForm.WorkName;
            boardForm.CBoardForm.CurrentWork.WorkContent = workForm.WorkContent;

            if (boardForm.CBoardForm.isLabel)
            {
                boardForm.CBoardForm.UpdateWork();
            }
            else
            {
                boardForm.CBoardForm.CreateWork();
            }

            boardForm.CBoardForm.CurrentWork.WorkName = workForm.WorkName = "";
            boardForm.CBoardForm.CurrentWork.WorkContent = workForm.WorkContent = "";
        }
    }
}
