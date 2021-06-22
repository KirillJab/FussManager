using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager.Classes
{
    class WeekTaskDecorator : ControlDecorator
    {
        public WeekTaskDecorator(UserControl weekTaskControl, Color backColor)
        {
            uControl = weekTaskControl;
            uControl.BackColor = backColor;
            uControl.ForeColor = (backColor.GetBrightness() > 0.45) ? uControl.ForeColor = Color.FromArgb(7, 51, 107) : uControl.ForeColor = Color.Gainsboro;
        }
    }
}
