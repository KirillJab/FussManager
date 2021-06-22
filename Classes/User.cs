using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    abstract class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        internal abstract Schedule CurrentSchedule { get; set; }
        public abstract int CurrentScheduleIndex { get; }

        public abstract void SetCurrentSchedule(Schedule newSchedule);
        public abstract void SetCurrentSchedule(int index);
        public abstract void SetSchedule(int index, Schedule newSchedule);
        public abstract Schedule[] GetSchedules();
        public abstract void AddNewSchedule(string name);
        public abstract void AddSchedules(List<Schedule> schedules);
        public abstract void DeleteSchedule(int index);
    }
}
