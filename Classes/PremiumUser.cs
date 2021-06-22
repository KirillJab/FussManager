using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class PremiumUser : User
    {
        private int scheduleIndex;
        List<Schedule> schedules = new List<Schedule>();
        public List<Schedule> Schedules { get => schedules; private set => schedules = value; }
        public override int CurrentScheduleIndex { get => scheduleIndex; }
        internal override Schedule CurrentSchedule { get => Schedules[CurrentScheduleIndex]; set => Schedules[CurrentScheduleIndex] = value; }

        public PremiumUser(int scheduleIndex, List<Schedule> schedules, Schedule currentSchedule)
        {
            this.scheduleIndex = scheduleIndex;
            Schedules = schedules;
            CurrentSchedule = currentSchedule;
        }

        public PremiumUser()
        {
            scheduleIndex = 0;
        }
        public PremiumUser(List<Schedule> schedules)
        {
            Schedules = schedules;
            scheduleIndex = 0;
        }
        public PremiumUser(string name, string password, string emailAddress)
        {
            Name = name;
            Password = password;
            EmailAddress = emailAddress;
        }
        public PremiumUser(string name, string password, List<Schedule> schedules)
        {
            Name = name;
            Password = password;
            Schedules = schedules;
            scheduleIndex = 0;
        }
        public override void SetCurrentSchedule(Schedule newSchedule)
        {
            Schedules.Add(newSchedule);
            scheduleIndex = schedules.Count - 1;
        }
        public override void SetCurrentSchedule(int index)
        {
            scheduleIndex = index;
        }
        public override void SetSchedule(int index, Schedule schedule)
        {
            if (index < 0 && index > schedules.Count)
            {
                throw new ArgumentException();
            }
            schedules[index] = schedule;
        }
        public override Schedule[] GetSchedules()
        {
            return Schedules.ToArray();
        }

        public override void AddNewSchedule(string name)
        {
            Schedules.Add(new Schedule(new List<Year>(), name));
        }

        public override void DeleteSchedule(int index)
        {
            if (index < Schedules.Count && index >= 0)
            {
                Schedules.RemoveAt(index);
                SetCurrentSchedule(0);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void AddSchedules(List<Schedule> schedules)
        {
            Schedules.AddRange(schedules);
        }
    }
}
