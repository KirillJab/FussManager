using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class NonPremiumUser : User
    {
        private static int poolSize = 3;
        private int scheduleIndex;
        private int schedulesTotal;
        Schedule[] schedules = new Schedule[poolSize];
        public Schedule[] Schedules { get => schedules; set => schedules = value; }
        public override int CurrentScheduleIndex { get => scheduleIndex; }
        internal override Schedule CurrentSchedule { get => Schedules[scheduleIndex]; set => Schedules[scheduleIndex] = value; }

        public NonPremiumUser(int scheduleIndex, int schedulesTotal, Schedule[] schedules, Schedule currentSchedule)
        {
            this.scheduleIndex = scheduleIndex;
            this.schedulesTotal = schedulesTotal;
            Schedules = schedules;
            CurrentSchedule = currentSchedule;
        }

        public NonPremiumUser()
        {
            scheduleIndex = 0;
            schedulesTotal= 0;
        }
        public NonPremiumUser(Schedule[] schedulesArr)
        {
            if (schedulesArr.Length != 3)
            {
                throw new ArgumentException();
            }
            Schedules = schedulesArr;
            scheduleIndex = 0;
            schedulesTotal = 0;
        }
        public NonPremiumUser(string name, string password, string emailAddress)
        {
            Name = name;
            Password = password;
            EmailAddress = emailAddress;
            scheduleIndex = 0;
            schedulesTotal = 0;
        }


        public override void SetCurrentSchedule(Schedule newSchedule)
        {
            Schedules[scheduleIndex] = newSchedule;
        }

        public override void SetCurrentSchedule(int index)
        {
            if (index < 0 && index > schedulesTotal - 1)
            {
                throw new ArgumentException();
            }
            scheduleIndex = index;
        }

        public override void SetSchedule(int index, Schedule schedule)
        {
            if (index < 0 && index > schedulesTotal - 1)
            {
                throw new ArgumentException();
            }
            schedules[index] = schedule;
        }
        public override Schedule[] GetSchedules()
        {
            Schedule[] scheds = new Schedule[schedulesTotal];
            for (int i = 0; i < schedulesTotal; i++)
            {
                scheds[i] = Schedules[i];
            }
            return scheds;
        }
        public override void AddNewSchedule(string name)
        {
            if (schedulesTotal < 3)
            {
                Schedules[schedulesTotal] = new Schedule(new List<Year>(), name);
                schedulesTotal++;
            }
            else
            {
                throw new Exception("Non Premium Users can have only 3 schedules");
            }
        }
        public override void DeleteSchedule(int index)
        {
            if (index < Schedules.Length && index >= 0)
            {
                for (int i = index; i < Schedules.Length - 1; i++)
                {
                    Schedules[i] = Schedules[i + 1];
                }
                schedulesTotal--;
                SetCurrentSchedule(0);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void AddSchedules(List<Schedule> schedules)
        {
            throw new Exception("This feature is not supported for Non-premium users");
        }
    }
}
