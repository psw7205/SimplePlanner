using SimplePlanner.Model;
using SimplePlanner.View;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimplePlanner.Controller
{
    public class BoardFormController
    {
        readonly BoardForm boardForm;
        readonly WorkForm workForm;

        // 관리할 데이터
        public BoardData BoardData;

        // 일정 클릭 시 현재 클릭한 일정 정보
        public WorkData CurrentWork;
        public Label CurrentLabel;
        public int CurrentWorkIndex;

        // 새 일정 버튼인지 일정 라벨인지 구분할 flag
        public bool isLabel;

        // 생성자 컨트롤러 생성 시 보드 폼, 일정 폼을 컨트롤러와 연결
        public BoardFormController(BoardForm _boardForm, WorkForm _workForm)
        {
            boardForm = _boardForm;
            workForm = _workForm;
            BoardData = new BoardData("New Board");
            CurrentWork = new WorkData();
            isLabel = false;
        }

        // 프로그램 최초 실행 시 기본 탭 생성
        // 기존에 데이터가 있는 경우 실행 X
        public void Init()
        {
            BoardData.Tabs.Add(new TabData("To do"));
            BoardData.AddTab(boardForm, "To do");
            BoardData.Tabs.Add(new TabData("Doing"));
            BoardData.AddTab(boardForm, "Doing");
            BoardData.Tabs.Add(new TabData("Done"));
            BoardData.AddTab(boardForm, "Done");
        }

        // 보드 폼에서 일정 폼을 열 때
        public void OpenWorkForm()
        {
            // 라벨을 클릭했다면 
            // 해당 라벨의 일정 데이터를 가져와 일정폼 열기
            if (isLabel)
            {
                int tabIndex = boardForm.TabControl.SelectedIndex;
                TabData tabData = BoardData.Tabs.ElementAt(tabIndex);

                foreach (var item in tabData.Works)
                {
                    if (item.MyID == CurrentWorkIndex)
                    {
                        CurrentWork.WorkName = item.WorkName;
                        CurrentWork.WorkContent = item.WorkContent;
                        break;
                    }
                }

                workForm.WorkName = CurrentWork.WorkName;
                workForm.WorkContent = CurrentWork.WorkContent;
            }

            workForm.ShowDialog();
        }

        // 보드 폼에서 새 탭을 추가하는 경우
        // 보드 데이터 추가, 탭 추가
        public void AddTabData(string name = "New Tab")
        {
            BoardData.Tabs.Add(new TabData(name));
            BoardData.AddTab(boardForm, name);
        }

        // 탭 삭제
        // 탭은 무조건 1개 이상 존재
        public void DelTabData()
        {
            if (boardForm.TabControl.TabCount > 1)
            {
                BoardData.Tabs.RemoveAt(boardForm.TabControl.SelectedIndex);
                BoardData.DelTab(boardForm);
            }
        }

        // 새 일정 버튼이 현재 탭에 위치하도록
        public void MoveBtn()
        {
            boardForm.TabControl.SelectedTab.Controls.Add(boardForm.CreateWorkBtn);
        }

        // 새 일정을 만들 때 호출
        // 현제 탭 데이터를 가져와 일정 추가
        public void CreateWork()
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabData tabData = BoardData.Tabs.ElementAt(tabIndex);
            tabData.Works.Add(new WorkData(CurrentWork.WorkName, CurrentWork.WorkContent));
            tabData.AddWorkLabel(boardForm);
        }

        // 라벨이 클릭 될 때
        public void LabelClick(Label label)
        {
            isLabel = true;
            CurrentLabel = label;
            CurrentWorkIndex = int.Parse(Regex.Replace(CurrentLabel.Name, @"\D", ""));
            OpenWorkForm();
        }

        // 기존 일정을 수정할 때
        // 현재 클릭된 라벨을 찾아 해당 라벨의 Text 수정
        public void UpdateWork()
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabData tabData = BoardData.Tabs.ElementAt(tabIndex);

            foreach (var item in tabData.Works)
            {
                if (item.MyID == CurrentWorkIndex)
                {
                    item.WorkName = CurrentWork.WorkName;
                    item.WorkContent = CurrentWork.WorkContent;
                    item.UpdateLabelText(boardForm);
                    break;
                }
            }
        }
    }
}
