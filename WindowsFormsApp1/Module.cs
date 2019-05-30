using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Board
    {
        static Form1 form; //Board 와 Form1은 서로 1:1 대응관계

        //Board class
        //멤버 변수
        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public List<Tab> tabs;
        
        public Form1 Form {
            get { return form; }
            set { form = value; }
        }

        //생성자
        public Board() {
            name = "newBoard";
            tabs = new List<Tab>();

        }
        public Board(String name) {
            this.name = name;
            tabs = new List<Tab>();
        }

    }

    public class Tab : TabPage
    {
    
        public List<Work> works;

        //생성자
        public Tab()
        {
            //Name = "newTab";
            Text = "newTab";
            works = new List<Work>();
        }
        public Tab(String name)
        {
            //this.Name = name;
            Text = name;
            works = new List<Work>();
        }

        //메서드
        public void CreateNewWork(String name, String content, int tabPageIndex, Form1 form)
        {
            this.works.Add(new Work(name, content));
            form.ShowNewWorkOnTabPage(tabPageIndex, name, this.works.Count);
        }

    }

    public class Work : Label
    {
        //멤버 변수
       
        private String content;
        public String Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        //생성자
        public Work()
        {
            content = "";

            Text = "newWork";
        }
        public Work(String name)
        {
            content = "";

            Text = name;
        }
        public Work(String name, String content)
        {
            this.content = content;

            Text = name;
        }
    }
}