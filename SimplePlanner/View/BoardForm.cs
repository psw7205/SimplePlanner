using SimplePlanner.Controller;
using SimplePlanner.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class BoardForm : Form
    {
        readonly WorkForm workForm;
        readonly TabEditForm tabEditForm;

        public BoardFormController CBoardForm;
        public WorkFormController CWorkForm;
        public TabEditFormController CTabForm;
        public DataController CData;
        public MoveWorkFormController CMoveWorkForm;

        public Button CreateWorkBtn { get; }
        //taeyoon
        public Button MoveWorkBtn { get; }
        
        public TabControl TabControl
        {
            get { return tabControl; }
        }

        /// <summary>
        /// 보드 폼 생성자, 프로그램 실행 시 최초 호출
        /// </summary>
        public BoardForm()
        {
            InitializeComponent();

            workForm = new WorkForm();
            tabEditForm = new TabEditForm();
         

            CreateWorkBtn = new Button
            {
                Size = new Size(100, 30),
                Location = new Point(10, 10),
                Text = "새 일정",
                Name = "MakeNewWorkButton",
                UseVisualStyleBackColor = true
            };
            CreateWorkBtn.Click += (s, e) =>
            {
                CBoardForm.isLabel = false;
                CBoardForm.OpenWorkForm();
            };
            //taeyoon
            MoveWorkBtn = new Button {
                Size = new Size(100, 30),
                Location = new Point(150, 10),
                Text = "일정 이동",
                UseVisualStyleBackColor = true
            };
            MoveWorkBtn.Click += (s, e) =>
            {


                CBoardForm.OpneMoveWorkForm();
            };

            // 폼 생성
            CBoardForm = new BoardFormController(this, workForm);
            CWorkForm = new WorkFormController(this, workForm);
            CTabForm = new TabEditFormController(tabEditForm);
            CMoveWorkForm = new MoveWorkFormController(this);
            // 폼에 컨트롤러 연결
            workForm.Link(CWorkForm);

            // 기존 데이터 불러오기
            // 정상적으로 데이터를 불러 왔다면 불러온 데이터로 초기화
            // null이라면 기본 데이터로 초기화
            CData = new DataController();
            BoardData tmp = CData.DeserializeData();
            if (tmp != null)
            {
                CBoardForm.BoardData = tmp;
                CData.Init(this);
            }
            else
            {
                CBoardForm.Init();
            }

        }

        /// <summary>
        /// 탭 추가 버튼 클릭 시
        /// 탭 폼에서 반환된 데이터로 새 탭 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = CTabForm.OpenTabEditForm();
            if (name != "")
                CBoardForm.AddTabData(name);
        }

        /// <summary>
        /// 탭 변경시 컨트롤러에서 MoveBtn() 호출로 생성버튼 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            CBoardForm.MoveBtn();
        }

        /// <summary>
        /// 프로그램 종료 시 데이터 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CData.SerializeData(CBoardForm.BoardData);
        }

        /// <summary>
        /// 탭 수정 버튼 클릭 시 
        /// 탭 폼에서 반환된 데이터로 탭 이름 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            string name = CTabForm.OpenTabEditForm();
            if (name != "")
                CBoardForm.UpdateTabData(name);
        }

        /// <summary>
        /// 삭제 버튼 클릭시 컨트롤러에서 DelTabData()호출로 탭 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            CBoardForm.DelTabData();
        }

        /// <summary>
        /// 캘린더 열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalendarClick(object sender, EventArgs e)
        {
            (new CalendarForm(CBoardForm.BoardData)).ShowDialog();
        }
    }
}
