using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
   class Month
    {
        Day[] days = new Day[31];

        public Day[] Days { get => days; set => days = value; }

        public Month()
        {
            for (int i = 0; i < 31; i++)
            {
                days[i] = new Day();
            }
        }
        public Month(Day[] days)
        {
            Days = days;
        }

    }
}
