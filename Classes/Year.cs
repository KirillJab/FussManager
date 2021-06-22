using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class Year
    {
        public Month[] Months { get; set; }
        public int YearNumber { get; set; }

        public Year()
        {

        }
        public Year(Month[] Months, int YearNumber)
        {
            this.Months = Months;
            this.YearNumber = YearNumber;
        }
        public enum MonthsNames
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public Year(int yearNumb)
        {
            Months = new Month[12];
            YearNumber = yearNumb;
            for (int i = 0; i < 12; i++)
            {
                Months[i] = new Month();
            }
        }
    }
}
