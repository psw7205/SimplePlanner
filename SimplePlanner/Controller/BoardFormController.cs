using SimplePlanner.Model;
using SimplePlanner.View;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimplePlanner.Controller
{
    public class BoardFormController
    {
        readonly BoardForm boardForm;
        readonly WorkForm workForm;

        /// <summary>
        /// 관리할 데이터
        /// </summary>
        public BoardData BoardData;

        /// <summary>
        /// 현재 클릭한 일정 정보
        /// </summary>
        public WorkData CurrentWork;
        public Label CurrentLabel;
        public int CurrentWorkIndex;

        /// <summary>
        ///  클릭한 게 새 일정 버튼인지 일정 라벨인지 구분할 flag
        /// </summary>
        public bool isLabel;

        /// <summary>
        /// 생성자 컨트롤러 생성 시 보드 폼, 일정 폼을 컨트롤러와 연결
        /// </summary>
        /// <param name="_boardForm"></param>
        /// <param name="_workForm"></param>
        public BoardFormController(BoardForm _boardForm, WorkForm _workForm)
        {
            boardForm = _boardForm;
            workForm = _workForm;
            BoardData = new BoardData("New Board");
            CurrentWork = new WorkData();
            isLabel = false;
        }

        /// <summary>
        /// 프로그램 최초 실행 시 기본 탭 생성
        /// 기존에 데이터가 있는 경우 실행 X
        /// </summary>
        public void Init()
        {
            BoardData.Tabs.Add(new TabData("To do"));
            BoardData.AddTab(boardForm, "To do");
            BoardData.Tabs.Add(new TabData("Doing"));
            BoardData.AddTab(boardForm, "Doing");
            BoardData.Tabs.Add(new TabData("Done"));
            BoardData.AddTab(boardForm, "Done");
        }

        /// <summary>
        /// 보드 폼에서 일정 폼을 열 때
        /// </summary>
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
                        CurrentWork.Color = item.Color;
                        CurrentWork.Date = item.Date;
                        break;
                    }
                }
            }

            workForm.WorkName = CurrentWork.WorkName;
            workForm.WorkContent = CurrentWork.WorkContent;
            workForm.colorLabel.BackColor = CurrentWork.Color;
            workForm.date = CurrentWork.Date;

            workForm.ShowDialog();

            CurrentWork.WorkName = workForm.WorkName = "";
            CurrentWork.WorkContent = workForm.WorkContent = "";
            CurrentWork.Color = workForm.colorLabel.BackColor = System.Drawing.Color.White;
            CurrentWork.Date = workForm.date = DateTime.Today;
        }


        /// <summary>
        /// 보드 폼에서 새 탭을 추가하는 경우
        /// 보드 데이터 추가, 탭 추가
        /// </summary>
        /// <param name="name"></param>
        public void AddTabData(string name = "New Tab")
        {
            BoardData.Tabs.Add(new TabData(name));
            BoardData.AddTab(boardForm, name);
        }

        /// <summary>
        /// 탭 데이터 변경
        /// </summary>
        /// <param name="_name"></param>
        public void UpdateTabData(string _name)
        {
            BoardData.Tabs[boardForm.TabControl.SelectedIndex].TabName = _name;
            BoardData.UpdateTabName(boardForm, _name);
        }

        /// <summary>
        /// 탭 데이터 삭제
        /// </summary>
        public void DelTabData()
        {
            if (boardForm.TabControl.TabCount > 1)
            {
                BoardData.Tabs.RemoveAt(boardForm.TabControl.SelectedIndex);
                BoardData.DelTab(boardForm);
            }
        }

        /// <summary>
        /// 새 일정 버튼이 현재 탭에 위치하도록 이동
        /// </summary>
        public void MoveBtn()
        {
            boardForm.TabControl.SelectedTab.Controls.Add(boardForm.CreateWorkBtn);
        }

        /// <summary>
        /// 새 일정을 만들 때 호출
        /// 현재 탭 데이터를 가져와 일정 추가
        /// </summary>
        public void CreateWork()
        {
            int tabIndex = boardForm.TabControl.SelectedIndex;
            TabData tabData = BoardData.Tabs.ElementAt(tabIndex);
            WorkData tmp = new WorkData(CurrentWork.WorkName, CurrentWork.WorkContent)
            {
                Color = CurrentWork.Color,
                Date = CurrentWork.Date
            };
            tabData.Works.Add(tmp);
            tabData.AddWorkLabel(boardForm);
        }

        /// <summary>
        /// 라벨이 클릭 될 때 호출되는 함수
        /// </summary>
        /// <param name="label"></param>
        public void LabelClick(Label label)
        {
            isLabel = true;
            CurrentLabel = label;
            CurrentWorkIndex = int.Parse(Regex.Replace(CurrentLabel.Name, @"\D", ""));
            OpenWorkForm();
        }

        /// <summary>
        /// 기존 일정을 수정할 때 호출되는 함수
        /// 현재 클릭된 라벨을 찾아 해당 라벨의 Text 수정
        /// </summary>
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
                    item.Color = CurrentWork.Color;
                    item.Date = CurrentWork.Date;

                    item.UpdateLabelText(boardForm);
                    break;
                }
            }
        }
    }
}
