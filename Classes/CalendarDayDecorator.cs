using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager.Classes
{
    class CalendarDayDecorator : ControlDecorator
    {
        public CalendarDayDecorator(UserControl dayControl)
        {
            uControl = dayControl;
            ((CalendarDayControl)uControl).LabelDate.ForeColor = Color.White;
        }
    }
}
