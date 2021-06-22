using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class Schedule
    {
        public List<Year> Years { get; set; }
        public string Name { get; private set; }

        public Schedule(List<Year> Years, string Name)
        {
            this.Years = Years;
            this.Name = Name;
        }
        public Year GetYear(int yearNumb)
        {
            foreach (var year in Years)
            {
                if (year.YearNumber == yearNumb)
                {
                    return year;
                }
            }
            Years.Add(new Year(yearNumb));
            return Years.Last<Year>();
        }

        internal void SetName(string name)
        {
            Name = name;
        }
    }
}
