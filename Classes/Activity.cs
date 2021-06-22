using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    public class Activity
    {
        string name;
        string timeStart;
        string timeFinish;
        Color backColor;
        public string Name { get => name; set => name = value; }
        public string Time { get => String.Concat(timeStart, " - ", TimeFinish); }
        //public DateTime Date { get; set; }
        public int Row
        {
            get
            {
                var start = timeStart.Split(':');
                int[] a = new int[2] { Int32.Parse(start[0]), Int32.Parse(start[1]) == 00 ? 0 : 1 };
                return a[0] * 2 + a[1];
            }
        }
        public int RowSpan
        {
            get {
                var start = timeStart.Split(':');
                var finish = timeFinish.Split(':');
                int[] a = new int[2] { Int32.Parse(start[0]), Int32.Parse(start[1]) == 00 ? 0 : 1 };
                int[] b = new int[2] { Int32.Parse(finish[0]), Int32.Parse(finish[1]) == 00 ? 0 : 1 };
                return (b[0] - a[0]) * 2 + (b[1] - a[1]);
            }
        }
        public string TimeStart { get => timeStart; set => timeStart = value; }
        public string TimeFinish { get => timeFinish; set => timeFinish = value; }
        public Color BackColor { get => backColor; set => backColor = value; }

        public Activity()
        {

        }

        public Activity(string taskName, string taskStartTime, string taskFinishTime, Color backColor)
        {
            Name = taskName;
            TimeStart = taskStartTime;
            TimeFinish = taskFinishTime;
            BackColor = backColor;
        }
    }
}