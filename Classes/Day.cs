using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class Day
    {
        List<Activity> activities = new List<Activity>();
        public List<Activity> Activities { get => activities; set => activities = value; }
        public Day()
        {

        }

        public Day(List<Activity> listActivities)
        {
            Activities = listActivities;
        }
        public int FindIndexOfActivity(string timeStart)
        {
            int index = 0;
            foreach (var task in activities)
            {
                if(task.TimeStart == timeStart)
                {
                    return index;
                }
                index++;
            }
            throw new ArgumentException();
        }
    }
}
