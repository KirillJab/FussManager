using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager.Classes
{
    class CalendarDayOutDecorator : ControlDecorator
    {
        public CalendarDayOutDecorator(UserControl dayControl)
        {
            uControl = dayControl;
            ((CalendarDayControl)uControl).LabelDate.ForeColor = Color.RosyBrown;
        }
    }
}