using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SuetaManager.Program;
using SuetaManager.Classes;

namespace SuetaManager
{
    public partial class WeekForm : Form
    {
        int memeCountDown;
        public delegate void MemeHandler();
        public static event MemeHandler OnMemeReady;

        private List<string> timePick = new List<string>();
        private DateTime time = DateTime.Now;
        Label[] labelDates;
        DateTime[] dateTimes = new DateTime[7];
        public WeekForm()
        {
            InitializeComponent();
            memeCountDown = 3;
            labelDates = new Label[7] { labelMon, labelTue, labelWed, labelThu, labelFri, labelSat, labelSun };
            UpdateWeek(time);
            timePick.Add("00:00");
            comboBoxTimeStart.Items.AddRange(timePick.ToArray());
            comboBoxTimeStart.Items.RemoveAt(timePick.Count - 1);
            comboBoxTimeFinish.Items.AddRange(timePick.GetRange(1, timePick.Count - 1).ToArray());

            UserManager.OnUserChanged += ResetCounter;
        }

        private void ResetCounter()
        {
            memeCountDown = 3;
        }

        public void UpdateWeek(DateTime time)
        {
            int today = DateTime.Now.DayOfYear + DateTime.Now.Year * 1000;

            tableWeek.Visible = false;
            tableWeek.Controls.Clear();
            tableWeek.SuspendLayout();
            timePick.Clear();

            for (int i = 0; i < 7; i++)
            {
                labelDates[i].Parent.BackColor = labelDates[i].Parent.Parent.BackColor;
            }
            for (int i = 0; i < 48; i++)
            {
                timePick.Add($"{i / 2}:" + (i % 2 == 1 ? "30" : "00"));
                tableWeek.Controls.Add(new TimeControl(timePick[i], tableWeek.BackColor, Color.FromArgb(7, 51, 107)), 0, i);
            }
            while (time.DayOfWeek != DayOfWeek.Monday)
            {
                time = time.AddDays(-1);
            }
            for (int i = 0; i < 7; i++)
            {
                labelDates[i].Text = string.Concat(time.Day.ToString(), ".", time.Month < 10 ? string.Concat("0", time.Month) : time.Month.ToString());
                if (time.DayOfYear + time.Year * 1000 == today)
                {
                    labelDates[i].Parent.BackColor = Color.FromArgb(255, 170, 170);
                }
                foreach (var item in MainForm.UserManager.CurrentUser.CurrentSchedule.GetYear(time.Year).Months[time.Month - 1].Days[time.Day - 1].Activities)
                {
                    WeekTaskControl task = new WeekTaskControl(item.Time, item.Name);
                    WeekTaskDecorator coloredTask = new WeekTaskDecorator(task, item.BackColor);
                    tableWeek.SetRowSpan(coloredTask.uControl, item.RowSpan);
                    tableWeek.Controls.Add(coloredTask.uControl, i + 1, item.Row);
                }
                dateTimes[i] = time;
                time = time.AddDays(1);
            }
            labelMonth.Text = ((Year.MonthsNames)time.Month - 1).ToString().ToUpperInvariant();
            labelYear.Text = time.Year.ToString();

            tableWeek.ResumeLayout();
            tableWeek.Visible = true;
        }

        private void comboBoxTimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = comboBoxTimeStart.SelectedIndex + 1;
            comboBoxTimeFinish.Items.Clear();
            comboBoxTimeFinish.Items.AddRange(timePick.GetRange(n,timePick.Count - n).ToArray());

            if(comboBoxTimeFinish.SelectedIndex < n)
            {
                comboBoxTimeFinish.Text = "End Time";
            }
        }
        private void iconButtonAddToTable_Click(object sender, EventArgs e)
        {
            if (textBoxTaskName.Text.Trim() == string.Empty || comboBoxTimeStart.SelectedItem == null || comboBoxTimeFinish.SelectedItem == null || comboBoxWeekDay.SelectedItem == null)
            {
                MessageBox.Show("One of the fields is empty");
                return;
            }

            int rowSpan = comboBoxTimeFinish.SelectedIndex + 1;

            for (int i = 0; i <= rowSpan; i++)
            {
                var a = tableWeek.GetControlFromPosition(comboBoxWeekDay.SelectedIndex + 1, comboBoxTimeStart.SelectedIndex + i);
                if (a != null)
                {
                    MessageBox.Show("You already have a scheduled task on this time");
                    return;
                }
            }
            if(colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            WeekTaskControl task = new WeekTaskControl(string.Concat(comboBoxTimeStart.SelectedItem, "-", comboBoxTimeFinish.SelectedItem), textBoxTaskName.Text);
            WeekTaskDecorator weekTaskDecorator = new WeekTaskDecorator(task, colorDialog1.Color);
            tableWeek.SetRowSpan(weekTaskDecorator.uControl, comboBoxTimeFinish.SelectedIndex + 1);
            tableWeek.Controls.Add(weekTaskDecorator.uControl, comboBoxWeekDay.SelectedIndex + 1, comboBoxTimeStart.SelectedIndex);

            DateTime day = dateTimes[comboBoxWeekDay.SelectedIndex];
            MainForm.UserManager.CurrentUser.CurrentSchedule.GetYear(day.Year).Months[day.Month - 1].Days[day.Day - 1].Activities.Add(new Activity(textBoxTaskName.Text, comboBoxTimeStart.Text, comboBoxTimeFinish.Text, colorDialog1.Color));
        }

        private void iconButtonForward_Click(object sender, EventArgs e)
        {
            time = time.AddDays(7);
            UpdateWeek(time);
        }

        private void iconButtonBackward_Click(object sender, EventArgs e)
        {
            time = time.AddDays(-7);
            UpdateWeek(time);
        }

        private void iconButtonToday_Click(object sender, EventArgs e)
        {
            time = DateTime.Now;
            UpdateWeek(time);
        }

        private void WeekForm_Shown(object sender, EventArgs e)
        {
            UpdateWeek(time);
        }

        private void labelYear_Click(object sender, EventArgs e)
        {
            memeCountDown--;
            if (memeCountDown == 0)
            {
                OnMemeReady();
            }
        }
    }
}
