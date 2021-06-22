using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuetaManager.Classes;

namespace SuetaManager
{
    public partial class CalendarDayControl : UserControl
    {
        bool outDay;
        bool today;
        List<Activity> activities = new List<Activity>();
        public bool OutDay { get => outDay; set => outDay = value; }
        public bool Today { get => today; set => today = value; }
        public Label LabelDate { get => labelDate; set => labelDate = value; }
        internal List<Activity> Activities { get => activities; set => activities = value; }
        public CalendarDayControl(int day, List<Activity> listActivities)
        {
            InitializeComponent();
            labelDate.Text = day.ToString();
            foreach (var item in listActivities)
            {
                WeekTaskControl task = new WeekTaskControl(item.Time, item.Name);
                WeekTaskDecorator weekTaskDecorator = new WeekTaskDecorator(task, item.BackColor);
                flowLayoutPanel1.Controls.Add(weekTaskDecorator.uControl);
            }
        }
    }
}