using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SuetaManager.Classes;

namespace SuetaManager
{
    public partial class CalendarForm : Form
    {
        private DateTime time = DateTime.Now;
        public CalendarForm()
        {
            InitializeComponent();
            UpdateCalendar(time);
            labelMonth.TextAlign = ContentAlignment.MiddleRight;
        }
        private void UpdateCalendar(DateTime time)
        {
            int today = DateTime.Now.DayOfYear + DateTime.Now.Year * 1000;
            iconButtonToday.Enabled = true;
            tableLayoutCalendar.Controls.Clear();

            labelMonth.Text = ((Year.MonthsNames)time.Month - 1).ToString().ToUpperInvariant();
            labelYear.Text = time.Year.ToString();

            while(time.Day !=1)
            {
                time = time.AddDays(-1);
            }
            while(time.DayOfWeek != DayOfWeek.Monday)
            {
                time = time.AddDays(-1);
            }
            bool curMonth = false;
            for (int i = 0; i < 42; i++)
            {
                List<Activity> activities = MainForm.UserManager.CurrentUser.CurrentSchedule.GetYear(time.Year).Months[time.Month - 1].Days[time.Day - 1].Activities;
                CalendarDayControl day = new CalendarDayControl(time.Day, activities);
                ControlDecorator controlDecorator;
                if (curMonth)
                {
                    if (time.DayOfYear + time.Year * 1000 == today)
                    {
                        controlDecorator = new CalendarDayTodayDecorator(day);
                    }
                    else
                    {
                        controlDecorator = new CalendarDayDecorator(day);
                    }
                }
                else
                {
                    controlDecorator = new CalendarDayOutDecorator(day);
                }
                if (time.Day == DateTime.DaysInMonth(time.Year, time.Month))
                {
                    curMonth = !curMonth;
                }
                day.Dock = DockStyle.Fill;
                tableLayoutCalendar.Controls.Add(controlDecorator.uControl);
                time = time.AddDays(1);
            }
        }
        private void iconButtonForward_Click(object sender, EventArgs e)
        {
            time = time.AddMonths(1);
            UpdateCalendar(time);
        }

        private void iconButtonBackward_Click(object sender, EventArgs e)
        {
            time = time.AddMonths(-1);
            UpdateCalendar(time);

        }

        private void iconButtonToday_Click(object sender, EventArgs e)
        {
            time = DateTime.Now;
            UpdateCalendar(time);
        }

        private void CalendarForm_Shown(object sender, EventArgs e)
        {
            UpdateCalendar(time);
        }
    }
}
