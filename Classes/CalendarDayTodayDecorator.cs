using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager.Classes
{
    class CalendarDayTodayDecorator : ControlDecorator
    {
        public CalendarDayTodayDecorator(UserControl weekTaskControl)
        {
            uControl = weekTaskControl;
            uControl.BackColor = Color.FromArgb(255, 170, 180);
            ((CalendarDayControl)uControl).LabelDate.ForeColor = Color.White;
        }
    }
}
