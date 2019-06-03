using Calendar.NET;
using SimplePlanner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePlanner.View
{
    public partial class CalendarForm : Form
    {
        private BoardData data;

        public CalendarForm(BoardData _boardData)
        {
            InitializeComponent();
            calendar1.CalendarDate = DateTime.Now;
            calendar1.CalendarView = CalendarViews.Month;
            data = _boardData;
            foreach (var tabData in data.Tabs)
            {
                foreach (var item in tabData.Works)
                {
                    var exerciseEvent = new CustomEvent
                    {
                        Date = item.Date,
                        EventText = item.WorkName,
                        EventColor = item.Color
                    };

                    calendar1.AddEvent(exerciseEvent);
                }
            }
        }
    }
}
